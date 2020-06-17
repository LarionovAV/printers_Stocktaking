using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class CartrigesForm : Form
    {
        public CartrigesForm()
        {
            InitializeComponent();
            foreach (CartridgeModel item in CommonElements.CartridgeModels) {
                if (item.ID > 0)
                    ModelFilter.Items.Add(item);
            }
            ModelFilter.Items.Insert(0, new CartridgeModel(-1, "--Любая--"));
            ModelFilter.DisplayMember = "Name";

            foreach (CartridgeStatement item in CommonElements.CartridgeStatements)
            {
                if (item.ID > 0)
                    StateFilter.Items.Add(item);
            }
            StateFilter.Items.Insert(0, new CartridgeStatement(-1, "--Любое--"));
            StateFilter.DisplayMember = "Name";

            ModelFilter.SelectedIndex = StateFilter.SelectedIndex = 0;
        }

        private void RefreshFilterLists() {
            foreach (CartridgeModel item in CommonElements.CartridgeModels) {
                if (item.ID > 0 && !ModelFilter.Items.Contains(item))
                    ModelFilter.Items.Add(item);
            }

            foreach (CartridgeStatement item in CommonElements.CartridgeStatements)
            {
                if (item.ID > 0 && !StateFilter.Items.Contains(item))
                    StateFilter.Items.Add(item);
            }
        }
        private void CartrigesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            if (new NewCartridgeForm().ShowDialog() == DialogResult.OK)
                ReloadTable();
            RefreshFilterLists();
        }

        private void CartrigesForm_Load(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void cartridgeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (sender as DataGridView).Columns["moreInfo"].Index) {
                new OneCartridgeInfoForm((int)(sender as DataGridView)[idCol.Index, e.RowIndex].Value).ShowDialog();
                ReloadTable();
            }
        }

        private void ReloadTable() {
            cartridgeTable.Rows.Clear();
            string sql = "Select * FROM GetAllCartridges()";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                cartridgeTable.Rows.Add(
                    record.GetInt32(0),
                    record.GetString(1),
                    record.GetString(2),
                    record.GetString(3),
                    "Подробнее"
                    );
            }
            reader.Close();
        }

        private void ReloadCartListBtn_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string sql = 
                "Select \"cartridge_ID\" " +
                "FROM \"Cartridge\" " +
                "WHERE \"inventory_num\" = '" + searchLine.Text + "'";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int found = reader.GetInt32(0);
                reader.Close();
                new OneCartridgeInfoForm(found).ShowDialog();
                ReloadTable();
            }
            else {
                reader.Close();
                MessageBox.Show("Не удалось найти картридж.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void SubmitFilterBtn_Click(object sender, EventArgs e)
        {
            cartridgeTable.Rows.Clear();
            string sql = "Select * FROM GetAllCartridges()";
            if ((StateFilter.SelectedItem as CartridgeStatement).ID > 0){
                sql += " WHERE \"state_id\" = " + (StateFilter.SelectedItem as CartridgeStatement).ID;
                if ((ModelFilter.SelectedItem as CartridgeModel).ID > 0)
                    sql += " and \"model_id\" = " + (ModelFilter.SelectedItem as CartridgeModel).ID;
            }
            else if ((ModelFilter.SelectedItem as CartridgeModel).ID > 0)
                sql += " Where \"model_id\" = " + (ModelFilter.SelectedItem as CartridgeModel).ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                cartridgeTable.Rows.Add(
                    record.GetInt32(0),
                    record.GetString(1),
                    record.GetString(2),
                    record.GetString(3),
                    "Подробнее"
                    );
            }
            reader.Close();
        }
    }
}
