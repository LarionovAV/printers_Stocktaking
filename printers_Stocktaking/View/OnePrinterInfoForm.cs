using System;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class OnePrinterInfoForm : Form
    {
        bool needUpdate = false;
        public OnePrinterInfoForm()
        {
            InitializeComponent();
        }

        private void placementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MovePrinterForm().ShowDialog();
        }

        private void statementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ChangePrinterStatement().ShowDialog();
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
                MessageBox.Show("Были внесены изменения", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Save();
        }

        private void Save() {
        }

        private void changeCartridgeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SetPrintersCartridgeForm().ShowDialog();
        }

        private void showHistoryLimk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PrinterHistoryForm().ShowDialog();
        }

        private void printingInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PrintCountingForm().ShowDialog();
        }
    }
}
