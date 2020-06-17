using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class OneCartridgeInfoForm : Form
    {
        bool needUpdate = false;
        bool needRepair = false;
        int cartridgeID;
        int devID;
        int cartModelId;
        public OneCartridgeInfoForm()
        {
            InitializeComponent();
        }
        public OneCartridgeInfoForm(int cartID) : this()
        {
            cartridgeID = cartID;
            LoadInfo();
            needUpdate = false;
        }

        private void LoadInfo() {
            string sql = "select * from getCartridgeById(" + cartridgeID +")";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            invNum.Text = reader.GetString(0);
            modelLabel.Text = reader.GetString(1);
            devID = reader[2] == DBNull.Value? 0 : reader.GetInt32(2);
            if (devID == 0)
            {
                printerLink.Enabled = false;
                printerLink.Text = "Не установлен";
            }
            else
            {
                printerLink.Enabled = true;
                printerLink.Text = reader.GetString(3);
            }
            statementLink.Text = reader.GetString(4);
            cartModelId = reader.GetInt32(5);
            reader.Close();
            needRepair = (statementLink.Text == "В ремонте" || statementLink.Text == "На заправке");
        }
        private void printerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new OnePrinterInfoForm(devID).ShowDialog();
        }

        private void invNum_TextChanged(object sender, EventArgs e)
        {
            needUpdate = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CompatibilitiesForm(cartModelId).ShowDialog();
        }

        private void OneCartridgeInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needUpdate &&
                MessageBox.Show("Были внесены изменения.\nСохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Save();
        }

        private void Save() { }

        private void showHistoryLimk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CartridgeHistoryForm(cartridgeID).ShowDialog();
        }

        private void statementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (needRepair)
                new RepairForm().ShowDialog();
            else
                if (new ChangeCartridgeStatus(cartridgeID).ShowDialog() == DialogResult.OK)
                    LoadInfo();
        }
    }
}
