using Npgsql;
using printers_Stocktaking.Model;
using System.Data.Common;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class DoneActForm : Form
    {
        decimal TotalSumm = 0;
        public DoneActForm()
        {
            InitializeComponent();
        }
        public DoneActForm(int actID) : this()
        {
            string sql = "SELECT \"Buy_act\".\"buy_date\", \"Material\".\"name\", \"Buy_act_row\".\"quantity\", \"Buy_act_row\".\"total_cost\" " +
                "FROM \"Buy_act_row\", \"Material\", \"Buy_act\" " +
                "WHERE \"Buy_act_row\".\"act_ID\" = " + actID + " " +
                "and \"Material\".\"material_ID\" = \"Buy_act_row\".\"material_ID\" " +
                "and \"Buy_act_row\".\"act_ID\" = \"Buy_act\".\"act_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                actRows.Rows.Add(record[1], record[2], record[3]);
                TotalSumm += record.GetDecimal(3);
                buyDateLabel.Text = "Дата закупки: " + record.GetDateTime(0).ToString("dd-MM-yyyy");
            }
            
            reader.Close();

            totalLabel.Text = TotalSumm.ToString();
        }
    }
}
