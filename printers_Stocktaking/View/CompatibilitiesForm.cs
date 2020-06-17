using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class CompatibilitiesForm : Form
    {
        int cartModelID;
        public CompatibilitiesForm()
        {
            InitializeComponent();
        }
        public CompatibilitiesForm(int cart_moel_id) : this()
        {
            cartModelID = cart_moel_id;
            Init();
        }
        private void Init() {
            creator.DataSource = CommonElements.Creators;
            creator.DisplayMember = "Name";

            model.DataSource = CommonElements.PrinterModels;
            model.DisplayMember = "Name";

            compTable.Rows.Clear();
            string sql = "SELECT \"Creator\".\"name\", \"Device_model\".\"name\", \"Device_model\".\"model_ID\" " +
                "from \"Compatibility\", \"Creator\", \"Device_model\" " +
                "WHERE \"Compatibility\".\"cart_model_ID\" = " + cartModelID + " and " +
                "\"Compatibility\".\"model_ID\" = \"Device_model\".\"model_ID\" and " +
                "\"Compatibility\".\"creator_ID\" = \"Creator\".\"creator_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                compTable.Rows.Add(record[2], record[0], record[1], "Удалить");
            }
            reader.Close();
        }
        private void CompatibilitiesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddDepBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * from \"Compatibility\" " +
                "WHERE \"cart_model_ID\" = " + cartModelID + " and " +
                "\"model_ID\" = " + (model.SelectedItem as PrinterModel).ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                sql = "Insert Into \"Compatibility\"(\"cart_model_ID\", \"model_ID\", \"creator_ID\") " +
                "VALUES(" + cartModelID + ", " + (model.SelectedItem as PrinterModel).ID + ", " +
                (creator.SelectedItem as Creator).ID + ")";
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
                compTable.Rows.Add(
                    (model.SelectedItem as PrinterModel).ID, 
                    (creator.SelectedItem as Creator).Name, 
                    (model.SelectedItem as PrinterModel).Name, 
                    "Удалить");
            }
            else
                reader.Close();

        }

        private void creator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((creator.SelectedItem as Creator).ID == -1)
            {
                StringReference newCreatorName = new StringReference();
                if (new NewValueForm(newCreatorName, "Марка устройства").ShowDialog() == DialogResult.OK)
                {
                    Creator newCreator = new Creator(newCreatorName.Value);
                    newCreator.Create();
                    CommonElements.Creators.Insert(0, newCreator);
                    creator.SelectedIndex = 0;
                }
            }
            else
            {
                CommonElements.PrinterModels.Clear();
                string sql = "SELECT * FROM \"Device_model\" WHERE \"creator_ID\" = " + (creator.SelectedItem as Creator).ID;
                NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                foreach (DbDataRecord record in reader)
                {
                    CommonElements.PrinterModels.Add(
                        new PrinterModel(record.GetInt32(0), record.GetString(1), record.GetInt32(2)));
                }
                reader.Close();
                CommonElements.PrinterModels.Add(new PrinterModel(-1, "--Новая--", -1));
            }
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (model.SelectedItem != null && (model.SelectedItem as PrinterModel).ID == -1)
            {
                StringReference newModelName = new StringReference();
                if (new NewValueForm(newModelName, "Модель устройства").ShowDialog() == DialogResult.OK)
                {
                    PrinterModel newModel = new PrinterModel(newModelName.Value, (creator.SelectedItem as Creator).ID);
                    newModel.Create();
                    CommonElements.PrinterModels.Insert(0, newModel);
                    model.SelectedItem = 0;
                }
            }
        }

        private void compTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == delCol.Index) {
                string sql = "DELETE FROM \"Compatibility\" " +
                     "WHERE \"cart_model_ID\" = " + cartModelID +
                     " and \"model_ID\" = " + compTable[ID.Index, e.RowIndex].Value.ToString();
                compTable.Rows.RemoveAt(e.RowIndex);
  
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
            }
        }
    }
}
