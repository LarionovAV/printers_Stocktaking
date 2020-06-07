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
    public partial class CartrigesForm : Form
    {
        public CartrigesForm()
        {
            InitializeComponent();
        }

        private void CartrigesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            new NewCartridgeForm().ShowDialog();
        }

        private void CartrigesForm_Load(object sender, EventArgs e)
        {
            cartridgeTable.Rows.Add("-1", "Инв. номер", "Модель", "Состояние", "Подробнее");
        }

        private void cartridgeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (sender as DataGridView).Columns["moreInfo"].Index) {
                new OneCartridgeInfoForm().ShowDialog();
            }
        }
    }
}
