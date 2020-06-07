using System;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class CartridgeHistoryForm : Form
    {
        int cartId;
        bool nowRepair = false;
        public CartridgeHistoryForm()
        {
            InitializeComponent();
        }

        public CartridgeHistoryForm(int id) : this(){
            cartId = id;
        }

        private void CartridgeHistoryForm_Load(object sender, EventArgs e)
        {
            historyTable.Rows.Add("-1", "Номер принтера", "Дата с", "Дата по", "Статус", "Посмотреть");
        }

        private void historyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UsedMat.Index) {
                if (nowRepair)
                    new RepairForm().ShowDialog();
                else
                    new UsedMatherialForm().ShowDialog();

                nowRepair = !nowRepair;
            }
                
        }
    }
}
