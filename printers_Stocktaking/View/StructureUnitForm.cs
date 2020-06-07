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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            depTree.Nodes.Add(CommonElements.DepTreeRoot);
        }
    }
}
