using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.ComponentModel;
using System.Data.Common;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class SetPrintersCartridgeForm : Form
    {
        int DevID;
        public SetPrintersCartridgeForm()
        {
            InitializeComponent();
        }
        public SetPrintersCartridgeForm(int dev_id) : this()
        {
            DevID = dev_id;
            cartridgeInvNum.DataSource = new BindingList<Cartridge>();
            cartridgeInvNum.DisplayMember = "InventoryNum";
            cartridgeInvNum.ValueMember = "ID";
            string sql = "SELECT * from GetAvailableCartridges(" + dev_id + ")";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                (cartridgeInvNum.DataSource as BindingList<Cartridge>).Add(new Cartridge(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();
            
        }
        private void ChoiceCabinet_CheckedChanged(object sender, EventArgs e)
        {
            CartPanel.Enabled = (sender as RadioButton).Checked;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            TakeOffCurrentCartridge();
            if (SetCartridge.Checked)
                SetUpCartridge();
        }

        private void TakeOffCurrentCartridge() {
            string sql = "SELECT TakeOffCartridge(" + DevID + ")";
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        private void SetUpCartridge()
        {
            string sql = "SELECT SetUpCartridge(" + DevID + ", " + cartridgeInvNum.SelectedValue + ")";
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}