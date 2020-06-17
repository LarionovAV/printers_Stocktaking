using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class MovePrinterForm : Form
    {
        private int printerID;
        public MovePrinterForm()
        {
            InitializeComponent();
            building.DataSource = CommonElements.Buildings;
            building.DisplayMember = "Name";
        }
        public MovePrinterForm(int pID) : this(){
            printerID = pID;
        }

        private void ChoiceCabinet_CheckedChanged(object sender, EventArgs e)
        {
            CabPanel.Enabled = (sender as RadioButton).Checked;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            string sql;
            if (ToStorage.Checked)
            {
                sql = "SELECT MovePrinter(" + printerID + ", null, null)";
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
            }
            else {
                sql = "SELECT MovePrinter(" + printerID + ", '" + cabNum.Text + "', " 
                    + (building.SelectedItem as Building).ID + ")";
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
            }
        }
    }
}
