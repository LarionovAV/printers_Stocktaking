using printers_Stocktaking.Model;
using System;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class NewMaterialForm : Form
    {
        public NewMaterialForm()
        {
            InitializeComponent();
            measure.DataSource = CommonElements.Measures;
            measure.DisplayMember = "Name";
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            Material nm = new Material(matName.Text, 0, (measure.SelectedItem as Measure).ID);
            nm.Create();
        }
    }
}
