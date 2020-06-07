using printers_Stocktaking.Model;
using printers_Stocktaking.View;
using System;
using System.Windows.Forms;

namespace printers_Stocktaking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PrintersBTN_Click(object sender, EventArgs e)
        {
            Hide();
            new PrintersForm().Show();
        }

        private void OrgStructBTN_Click(object sender, EventArgs e)
        {
            Hide();
            new DepartmentForm().Show();
        }

        private void PrintingVolumeBTN_Click(object sender, EventArgs e)
        {
            Hide();
            new PrintingStatisticsForm().Show();
        }

        private void CartridgeBTN_Click(object sender, EventArgs e)
        {
            Hide();
            new CartrigesForm().ShowDialog();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new ConnectionPropertiesForm().ShowDialog();
        }

        private void UsingMatBTN_Click(object sender, EventArgs e)
        {
            Hide();
            new MatherialsForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CommonElements.Init();
        }
    }
}
