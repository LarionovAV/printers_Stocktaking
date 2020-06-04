using printers_Stocktaking.Model;
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
    public partial class NewValueForm : Form
    {
        StringReference value;
        public NewValueForm(StringReference val)
        {
            InitializeComponent();
            value = val;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            value.Value = newValue.Text;
        }
    }
}
