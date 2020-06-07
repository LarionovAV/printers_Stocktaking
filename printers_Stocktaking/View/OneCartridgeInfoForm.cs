using System;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class OneCartridgeInfoForm : Form
    {
        bool needUpdate = false;
        bool needRepair = false;
        public OneCartridgeInfoForm()
        {
            InitializeComponent();
        }

        private void printerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new OnePrinterInfoForm().ShowDialog();
        }

        private void invNum_TextChanged(object sender, EventArgs e)
        {
            needUpdate = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CompatibilitiesForm().ShowDialog();
        }

        private void OneCartridgeInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needUpdate &&
                MessageBox.Show("Были внесены изменения", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Save();
        }

        private void Save() { }

        private void showHistoryLimk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CartridgeHistoryForm().ShowDialog();
        }

        private void statementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (needRepair)
                new RepairForm().ShowDialog();
            else
                new ChangeCartridgeStatus().ShowDialog();

            needRepair = !needRepair;
        }
    }
}
