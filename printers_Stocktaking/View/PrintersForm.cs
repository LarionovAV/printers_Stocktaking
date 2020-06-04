using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class PrintersForm : Form
    {
        public PrintersForm()
        {
            InitializeComponent();
        }

        private void PrintersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        private void PrintersForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addPrinterBtn_Click(object sender, EventArgs e)
        {
            new NewPrinterForm().ShowDialog();
        }
    }
}
