using printers_Stocktaking.Model;
using System;
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
            searchMethod.Items.Add("Поиск по инвентаризационному номеру");
            searchMethod.Items.Add("Поиск по серийному номеру");
            searchMethod.SelectedIndex = 0;

            depTree.Nodes.Add(CommonElements.DepTreeRoot);

            printersTable.Rows.Add("-1", "Инв. Номер", "Модель", "Состояние", "Подробнее");
        }

        private void addPrinterBtn_Click(object sender, EventArgs e)
        {
            new NewPrinterForm().ShowDialog();
        }

        private void SubmitFilterBtn_Click(object sender, EventArgs e)
        {

        }

        private void printersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (sender as DataGridView).Columns["moreInfo"].Index) {
                new OnePrinterInfoForm().ShowDialog();
            }
        }
    }
}
