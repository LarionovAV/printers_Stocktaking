using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printers_Stocktaking
{
    public partial class ConnectionPropertiesForm : Form
    {
        public ConnectionPropertiesForm()
        {
            InitializeComponent();
        }

        private void ConnectionPropertiesForm_Load(object sender, EventArgs e)
        {
            AddressTB.Text = Properties.Settings.Default.DB_Address;
            PortTB.Text = Properties.Settings.Default.DB_Port;
            DbNameTB.Text = Properties.Settings.Default.DB_Name;
        }
    }
}
