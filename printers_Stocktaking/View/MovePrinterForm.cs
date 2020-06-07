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
    public partial class MovePrinterForm : Form
    {
        public MovePrinterForm()
        {
            InitializeComponent();
        }

        private void ChoiceCabinet_CheckedChanged(object sender, EventArgs e)
        {
            CabPanel.Enabled = (sender as RadioButton).Checked;
        }
    }
}
