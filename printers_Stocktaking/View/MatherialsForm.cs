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
    public partial class MatherialsForm : Form
    {
        bool isOpen = false;
        public MatherialsForm()
        {
            InitializeComponent();
        }

        private void addActBtn_Click(object sender, EventArgs e)
        {
            new NotDoneActForm().ShowDialog();
        }

        private void BuyMatherialsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == openAct.Index) {
                if (isOpen)
                    new NotDoneActForm().ShowDialog();
                else
                    new DoneActForm().ShowDialog();

                isOpen = !isOpen;
            }
        }

        private void BuyMatherialsForm_Load(object sender, EventArgs e)
        {
            actsTable.Rows.Add("-1", "Дата", "Просмотреть");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new NewMatherialFom().ShowDialog();
        }
    }
}
