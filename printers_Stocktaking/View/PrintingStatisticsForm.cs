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
    public partial class PrintingStatisticsForm : Form
    {
        public PrintingStatisticsForm()
        {
            InitializeComponent();
        }

        private void PrintingStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            department.Nodes.Clear();
            Application.OpenForms["MainForm"].Show();
        }

        private void PrintingStatisticsForm_Load(object sender, EventArgs e)
        {
            department.Nodes.Add(CommonElements.DepTreeRoot);
            department.SelectedNode = department.Nodes[0];
            Random rand = new Random();
            foreach (TreeNode node in department.SelectedNode.Nodes) {
                chart.Series["PrintingStat"].Points.InsertXY(0, node.Text, rand.Next(100, 1000));
            }
        }
    }
}
