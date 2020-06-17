using System;
using Npgsql;
namespace printers_Stocktaking.Model
{
    class DBConnection
    {
        private static NpgsqlConnection connection = null;

        private DBConnection(string user, string password) {
            try
            {
                string connectionString 
                    = "Server = " + Properties.Settings.Default.DB_Address
                    + "; Port = " + Properties.Settings.Default.DB_Port 
                    + "; Database = " + Properties.Settings.Default.DB_Name 
                    + "; User Id = " + user + "; Password = " + password + ";";
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception e) {
                connection = null;
            }
        }

        public static NpgsqlConnection getConnection(string user = "PrintersAdmin", string passsword = "printersadmin") {
            if (connection == null) {
                new DBConnection(user, passsword);
            }

            return connection;
        }
    }
}
