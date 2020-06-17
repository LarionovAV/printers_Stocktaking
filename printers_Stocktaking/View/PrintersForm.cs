using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class PrintersForm : Form
    {
        public PrintersForm()
        {
            InitializeComponent();
        }

        private void PrintersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
            depTree.Nodes.Clear();
        }

        private void PrintersForm_Load(object sender, EventArgs e)
        {
            searchMethod.Items.Add("Поиск по инвентаризационному номеру");
            searchMethod.Items.Add("Поиск по серийному номеру");
            searchMethod.SelectedIndex = 0;

            depTree.Nodes.Add(CommonElements.DepTreeRoot);
            depTree.SelectedNode = depTree.Nodes[0];

            CreatorFilter.DisplayMember = "Name";
            CreatorFilter.ValueMember = "ID";
            CreatorFilter.Items.Add(new Creator(-1, "--Любая--"));
            foreach (Creator creator in CommonElements.Creators) {
                if (creator.ID > 0) {
                    CreatorFilter.Items.Add(creator);
                }
            }
            CreatorFilter.SelectedIndex = 0;

            StateFilter.DisplayMember = "Name";
            StateFilter.ValueMember = "ID";
            StateFilter.Items.Add(new PrinterStatement(-1, "--Любое--"));
            foreach (PrinterStatement state in CommonElements.PrinterStatements)
            {
                if (state.ID > 0)
                {
                    StateFilter.Items.Add(state);
                }
            }
            StateFilter.SelectedIndex = 0;
            TableReload();
        }

        private void addPrinterBtn_Click(object sender, EventArgs e)
        {
            if (new NewPrinterForm().ShowDialog() == DialogResult.OK) {
                TableReload();
            }
        }

        private void TableReload() {
            printersTable.Rows.Clear();
            string sql = "Select * FROM GetAllPrinters()";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                printersTable.Rows.Add(
                    record.GetInt32(0),
                    record.GetString(1),
                    record[3] == DBNull.Value ? "Не установен" : record[3].ToString() + " " + record[4].ToString(),
                    record[2],
                    "Подробнее"
                    );
            }
            reader.Close();
        }
        private void SubmitFilterBtn_Click(object sender, EventArgs e)
        {
            printersTable.Rows.Clear();
            string sql = "Select * FROM GetAllPrinters() Where true";
            if (depTree.SelectedNode.Name != "NULL") {
                sql += " and \"dep_id\" = " + depTree.SelectedNode.Name;
            }
            if ((CreatorFilter.SelectedItem as Creator).ID != -1)
            {
                sql += " and \"creator_id\" = " + (CreatorFilter.SelectedItem as Creator).ID;
                if ((ModelFilter.SelectedItem as PrinterModel).ID != -1)
                {
                    sql += " and \"model_id\" = " + (ModelFilter.SelectedItem as PrinterModel).ID;
                }
            }
            if ((StateFilter.SelectedItem as PrinterStatement).ID != -1)
            {
                sql += " and \"state_id\" = " + (StateFilter.SelectedItem as PrinterStatement).ID;
            }
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                printersTable.Rows.Add(
                    record.GetInt32(0),
                    record.GetString(1),
                    record[3] == DBNull.Value ? "Не установен" : record[3].ToString() + " " + record[4].ToString(),
                    record[2],
                    "Подробнее"
                    );
            }
            reader.Close();
        }

        private void printersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (sender as DataGridView).Columns["moreInfo"].Index) {
                new OnePrinterInfoForm((int)(sender as DataGridView)[printID.Index, e.RowIndex].Value).ShowDialog();
                TableReload();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql;
            NpgsqlDataReader reader;
            if (searchMethod.SelectedIndex == 0) {
                sql = "Select \"device_ID\" FROM \"Device\" WHERE \"inventory_number\" = '" + searchParam.Text + "'";
                reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int devID = reader.GetInt32(0);
                    reader.Close();
                    new OnePrinterInfoForm(devID).ShowDialog();
                    TableReload();
                }
                else {
                    MessageBox.Show("Принтер по указанным параметрам не найден.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
            }
            else {
                sql = "Select \"device_ID\" FROM \"Device\" WHERE \"serial_number\" = '" + searchParam.Text + "'";
                reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int devID = reader.GetInt32(0);
                    reader.Close();
                    new OnePrinterInfoForm(devID).ShowDialog();
                    TableReload();
                }
                else
                {
                    MessageBox.Show("Принтер по указанным параметрам не найден.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
            }

        }

        private void CreatorFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelFilter.Items.Clear();
            ModelFilter.DisplayMember = "Name";
            ModelFilter.ValueMember = "ID";

            ModelFilter.Items.Add(new PrinterModel(-1, "--Любая--", -1));
            string sql = "Select \"model_ID\", \"name\" From \"Device_model\" Where \"creator_ID\" = " + (CreatorFilter.SelectedItem as Creator).ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                ModelFilter.Items.Add(new PrinterModel(record.GetInt32(0), record.GetString(1), Convert.ToInt32(CreatorFilter.SelectedValue)));
            }
            reader.Close();
            ModelFilter.SelectedIndex = 0;
        }

        private void reloadListBtn_Click(object sender, EventArgs e)
        {
            TableReload();
        }
    }
}
