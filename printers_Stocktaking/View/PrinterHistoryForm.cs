using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class PrinterHistoryForm : Form
    {
        private int printerID;
        public PrinterHistoryForm()
        {
            InitializeComponent();
        }
        public PrinterHistoryForm(int pId) : this() {
            printerID = pId;
        }
        private void PrinterHistoryForm_Load(object sender, System.EventArgs e)
        {
            string sql = "Select * FROM GetPrinterHistory(" + printerID + ")";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                hisTab.Rows.Add(
                    record["cabNum"] == DBNull.Value? "-" : record["cabNum"].ToString() + " " + record["build"].ToString(),
                    record["cabNum"] == DBNull.Value ? "-" : record["dep"].ToString(),
                    record.GetDateTime(1).ToString("dd-MM-yyyy"),
                    record[2] == DBNull.Value? "-" : record.GetDateTime(2).ToString("dd-MM-yyyy"),
                    record["printer_status"]
                    );
            }
            reader.Close();
        }
    }
}
