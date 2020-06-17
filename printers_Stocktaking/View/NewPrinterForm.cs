using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class NewPrinterForm : Form
    {
        public NewPrinterForm()
        {
            InitializeComponent();
        }

        private void NewPrinterForm_Load(object sender, EventArgs e)
        {
            totalPages.Text = "0";

            printerType.DataSource = CommonElements.PrintersTypes;
            printerType.DisplayMember = "Name";


            creator.DataSource = CommonElements.Creators;
            creator.DisplayMember = "Name";


            model.DataSource = CommonElements.PrinterModels;
            model.DisplayMember = "Name";
        }

        private void printerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((printerType.SelectedItem as PrinterType).ID == -1) {
                StringReference newTypeName = new StringReference();
                if (new NewValueForm(newTypeName, "Тип устройства").ShowDialog() == DialogResult.OK) {
                    PrinterType pType = new PrinterType(newTypeName.Value);
                    pType.Create();
                    CommonElements.PrintersTypes.Insert(0, pType);
                    printerType.SelectedIndex = 0;
                }
            }
        }

        private void creator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((creator.SelectedItem as Creator).ID == -1)
            {
                StringReference newCreatorName = new StringReference();
                if (new NewValueForm(newCreatorName, "Марка устройства").ShowDialog() == DialogResult.OK)
                {
                    Creator newCreator = new Creator(newCreatorName.Value);
                    newCreator.Create();
                    CommonElements.Creators.Insert(0, newCreator);
                    creator.SelectedIndex = 0;
                }
            }
            else
            {
                CommonElements.PrinterModels.Clear();
                string sql = "SELECT * FROM \"Device_model\" WHERE \"creator_ID\" = " + (creator.SelectedItem as Creator).ID;
                NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                foreach (DbDataRecord record in reader)
                {
                    CommonElements.PrinterModels.Add(
                        new PrinterModel(record.GetInt32(0), record.GetString(1), record.GetInt32(2)));
                }
                reader.Close();
                CommonElements.PrinterModels.Add(new PrinterModel(-1, "--Новая--", -1));
            }
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (model.SelectedItem != null && (model.SelectedItem as PrinterModel).ID == -1)
            {
                StringReference newModelName = new StringReference();
                if (new NewValueForm(newModelName, "Модель устройства").ShowDialog() == DialogResult.OK)
                {
                    PrinterModel newModel = new PrinterModel(newModelName.Value, (creator.SelectedItem as Creator).ID);
                    newModel.Create();
                    CommonElements.PrinterModels.Insert(0, newModel);
                    model.SelectedItem = 0;
                }
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (invNum.Text.Trim() == "")
            {
                MessageBox.Show("Укажите инвентаризационный номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (serialNum.Text.Trim() == "")
            {
                MessageBox.Show("Укажите серийный номер номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((printerType.SelectedItem as PrinterType).ID == -1)
            {
                MessageBox.Show("Укажите тип устройства", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((creator.SelectedItem as Creator).ID == -1)
            {
                MessageBox.Show("Укажите марку устройства", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((model.SelectedItem as PrinterModel).ID == -1)
            {
                MessageBox.Show("Укажите модель устройства", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int newDevice;
                string sql =
                    "SELECT AddPrinter('" + invNum.Text.Trim() + "','" + serialNum.Text.Trim() + "', " +
                    totalPages.Text + "," + (printerType.SelectedItem as PrinterType).ID + ", " +
                    (model.SelectedItem as PrinterModel).ID + ", " + (creator.SelectedItem as Creator).ID + ")";
                NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                reader.Read();
                newDevice = reader.GetInt32(0);
                reader.Close();
                sql =
                    "SELECT AddPrinterHistoryRecord(" + newDevice + ", null, null, '" + buyDate.Value.ToString("dd-MM-yyyy") +  "', " +
                    CommonElements.PrinterStatements.First(st => st.Name == "В рабочем состоянии").ID + ")";
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();

                if (MessageBox.Show(
                    "Печатное устройство добавлено.\nДобавить картридж?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    new NewCartridgeForm(newDevice).ShowDialog();
            }
        }
    }
}
