using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printers_Stocktaking.Model
{
    class CartridgeModel : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public CartridgeModel() { }
        public CartridgeModel(string name)
        {
            Name = name.Trim();
        }
        public CartridgeModel(int id, string name) : this(name)
        {
            ID = id;
        }

        public void Create()
        {
            string sql = "INSERT INTO \"Cartridge_model\"(\"name\") " +
                "VALUES ('" + Name + "') RETURNING \"cart_model_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql = "DELETE FROM \"Cartridge_model\" " +
                "WHERE \"cart_model_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql = "SELECT \"name\" FROM \"Cartridge_model\" WHERE \"cart_model_ID\" = " + ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            Name = reader.GetString(0);
            reader.Close();
        }

        public void Update()
        {
            string sql = "UPDATE \"Cartridge_model\" " +
                "SET \"name\" = '" + Name + 
                "' WHERE \"cart_model_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
