using Npgsql;
using printers_Stocktaking.Model;
using System.Drawing;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class ChangeCartridgeStatus : Form
    {
        int cartID;
        public ChangeCartridgeStatus()
        {
            InitializeComponent();
            cartridgeStatus.DataSource = CommonElements.CartridgeStatements;
            cartridgeStatus.DisplayMember = "Name";
        }
        public ChangeCartridgeStatus(int cart_id) : this()
        {
            cartID = cart_id;
        }

        private void AcceptBtn_Click(object sender, System.EventArgs e)
        {
            string sql = "SELECT changeCartState(" + cartID + ", " 
                + (cartridgeStatus.SelectedItem as CartridgeStatement).ID + ")";
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
