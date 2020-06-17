using Npgsql;
using printers_Stocktaking.Model;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class ChangePrinterStatement : Form
    {
        private int printerID;
        public ChangePrinterStatement()
        {
            InitializeComponent();
            printerStatus.DataSource = CommonElements.PrinterStatements;
            printerStatus.DisplayMember = "Name";
        }
        public ChangePrinterStatement(int pId):this() {
            printerID = pId;
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AcceptBtn_Click(object sender, System.EventArgs e)
        {
            string sql = "SELECT ChangeDevState(" + printerID + ", " +
                (printerStatus.SelectedItem as PrinterStatement).ID + ")";
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
