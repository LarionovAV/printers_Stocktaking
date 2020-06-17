using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class OnePrinterInfoForm : Form
    {
        bool needUpdate;
        int cartID = -1;
        int devID;
        public OnePrinterInfoForm()
        {
            InitializeComponent();
        }
        public OnePrinterInfoForm(int ID) : this()
        {
            devID = ID;
            Init();
        }

        private void Init() {
            statementLink.Enabled = placementLink.Enabled = true;

            string sql = "SELECT * from getPrinterById(" + devID + ")";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            invNum.Text = reader.GetString(0);
            serialNum.Text = reader.GetString(1);
            devType.Text = reader.GetString(2);
            creatorLabel.Text = reader.GetString(3);
            modelLabel.Text = reader.GetString(4);
            if (reader[5] == DBNull.Value)
            {
                placementLink.Text = "Не установлен";
            }
            else
            {
                placementLink.Text = reader.GetString(5) + reader.GetString(6);
                if (reader[7] != DBNull.Value)
                    placementLink.Text += " | " + reader.GetString(7);
            }

            statementLink.Text = reader.GetString(8);
            if (statementLink.Text == "В ремонте")
                placementLink.Enabled = false;
            if (statementLink.Text == "Списано")
            {
                statementLink.Enabled = placementLink.Enabled = false;
            }
            printingInfoLink.Text = reader.GetInt32(9) + " / " + (reader[10] == DBNull.Value ? 0 : reader.GetInt32(10));
            reader.Close();

            sql = "SELECT \"Cartridge\".\"cartridge_ID\", \"Cartridge\".\"inventory_num\" " +
                "from \"Cartridge\", \"Cartridge_history\" " +
                "WHERE \"Cartridge\".\"cartridge_ID\" = \"Cartridge_history\".\"cartridge_ID\" and " +
                "\"Cartridge_history\".\"end_date\" is null and \"Cartridge_history\".\"device_ID\" = " + devID;
            reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                changeCartridgeLink.Text = reader.GetString(1);
                cartID = reader.GetInt32(0);
            }
            else {
                changeCartridgeLink.Text = "Не установлен";
                cartID = -1;
            }
            reader.Close();
            needUpdate = false;
        }
        private void placementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new MovePrinterForm(devID).ShowDialog() == DialogResult.OK)
                Init();
        }

        private void statementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new ChangePrinterStatement(devID).ShowDialog() == DialogResult.OK)
                Init();
        }

        private void invNum_TextChanged(object sender, EventArgs e)
        {
            needUpdate = true;
        }

        private void serialNum_TextChanged(object sender, EventArgs e)
        {
            needUpdate = true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnePrinterInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needUpdate &&
                MessageBox.Show("Были внесены изменения.\nСохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Save();
        }

        private void Save() {
        }

        private void changeCartridgeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new SetPrintersCartridgeForm(devID).ShowDialog() == DialogResult.OK)
                Init();

        }

        private void showHistoryLimk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PrinterHistoryForm(devID).ShowDialog();
        }

        private void printingInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PrintCountingForm().ShowDialog();
        }
    }
}
