using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class MaterialsForm : Form
    {
        public MaterialsForm()
        {
            InitializeComponent();
        }

        private void addActBtn_Click(object sender, EventArgs e)
        {
            string sql = "Insert into \"Buy_act\"(buy_date) values(null) returning \"act_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            int nAct = reader.GetInt32(0);
            actsTable.Rows.Insert(0, nAct, "Не завершено", "Просмотреть");
            reader.Close();
            new NotDoneActForm(nAct).ShowDialog();
            ReloadActTable();
            ReloadMatTable();
        }

        private void ReloadActTable() {
            actsTable.Rows.Clear();
            string sql = "SELECT * FROM \"Buy_act\" ORDER BY \"buy_date\" Desc";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                actsTable.Rows.Add(
                    record[0], 
                    record[1] == DBNull.Value? "Не завершено" : record.GetDateTime(1).ToString("dd-MM-yyyy"), 
                    "Просмотреть");
            }
            reader.Close();
        }
        private void BuyMatherialsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == openAct.Index) {
                if (actsTable[DateCol.Index, e.RowIndex].Value.ToString() == "Не завершено")
                    new NotDoneActForm((int)actsTable[actIdCol.Index, e.RowIndex].Value).ShowDialog();
                else
                    new DoneActForm((int)actsTable[actIdCol.Index, e.RowIndex].Value).ShowDialog();

                ReloadActTable();
                ReloadMatTable();
            }
        }

        private void BuyMatherialsForm_Load(object sender, EventArgs e)
        {
            ReloadActTable();
            ReloadMatTable();
        }

        private void ReloadMatTable() {
            availableMatTable.Rows.Clear();
            string sql = "SELECT \"name\", \"available\", \"measure_ID\" FROM \"Material\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                availableMatTable.Rows.Add(
                    record[0],
                    record[1],
                    CommonElements.Measures.First(meas => meas.ID == record.GetInt32(2)).ShortName);
            }
            reader.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new NewMaterialForm().ShowDialog();
        }


    }
}
