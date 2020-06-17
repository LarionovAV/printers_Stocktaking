using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class CartridgeHistoryForm : Form
    {
        int cartId;
        bool nowRepair = false;
        public CartridgeHistoryForm()
        {
            InitializeComponent();
        }

        public CartridgeHistoryForm(int id) : this(){
            cartId = id;
        }

        private void CartridgeHistoryForm_Load(object sender, EventArgs e)
        {
            string sql = "Select * from GetCartridgeHistory(" + cartId + ")";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                historyTable.Rows.Add(
                    record[0],
                    record[1] == DBNull.Value ? "-" : record.GetString(1),
                    record.GetDateTime(2).ToString("dd-MM-yyyy"),
                    record[3] == DBNull.Value ? "-" : record.GetDateTime(3).ToString("dd-MM-yyyy"),
                    record.GetString(4),
                    record.GetString(4) == "В ремонте" || record.GetString(4) == "На заправке" ? "Показать" : "");
            }
            reader.Close();
        }

        private void historyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UsedMat.Index) {
                if (nowRepair)
                    new RepairForm().ShowDialog();
                else
                    new UsedMaterialForm().ShowDialog();

                nowRepair = !nowRepair;
            }
                
        }
    }
}
