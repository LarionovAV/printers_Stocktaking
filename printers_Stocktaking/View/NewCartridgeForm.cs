using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class NewCartridgeForm : Form
    {
        private int deviceId = 0;
        public NewCartridgeForm()
        {
            InitializeComponent();

            model.DataSource = CommonElements.CartridgeModels;
            model.DisplayMember = "Name";

        }
        public NewCartridgeForm(int devID) : this() {
            deviceId = devID;
        }
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (invNum.Text.Trim() == "")
            {
                MessageBox.Show("Укажите инвентаризационный номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((model.SelectedItem as CartridgeModel).ID == -1)
            {
                MessageBox.Show("Укажите модель картриджа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newCart;
                string sql =
                    "SELECT AddCartridge('" + invNum.Text.Trim() + "'," +
                    (model.SelectedItem as CartridgeModel).ID + ")";
                NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                reader.Read();
                newCart = reader.GetInt32(0);
                reader.Close();
                sql =
                    "SELECT AddCartridgeHistoryRecord(" + 
                        newCart + ", " +
                        (deviceId == 0? "null" : deviceId.ToString()) + ", '" + 
                        buyDate.Value.ToString("dd-MM-yyyy") + "', " +
                        CommonElements.CartridgeStatements.First(st => st.Name == "В рабочем состоянии").ID + ")";
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();

                if (deviceId != 0)
                    sql =
                    "SELECT addCompatibility(" + newCart + ", " + deviceId + ")";
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
            }
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((model.SelectedItem as CartridgeModel).ID == -1) {
                StringReference newModel = new StringReference();
                if (new NewValueForm(newModel, "Модель картриджа").ShowDialog() == DialogResult.OK) {
                    CartridgeModel nMod = new CartridgeModel(newModel.Value);
                    nMod.Create();
                    CommonElements.CartridgeModels.Insert(0, nMod);
                    model.SelectedIndex = 0;
                }
            }
        }
    }
}
