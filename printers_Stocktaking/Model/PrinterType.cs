using Npgsql;

namespace printers_Stocktaking.Model
{
    class PrinterType : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public PrinterType() { }
        public PrinterType(string name)
        {
            Name = name.Trim();
        }
        public PrinterType(int id, string name = "") : this(name)
        {
            ID = id;
        }

        public void Create()
        {
            string sql = "INSERT INTO \"Device_type\"(\"name\") " +
                "VALUES ('" + Name + "') RETURNING \"device_type_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql = "DELETE FROM \"Device_type\" " +
                "WHERE \"device_type_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql = "SELECT \"name\" FROM \"Device_type\" WHERE \"device_type_ID\" = " + ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            Name = reader.GetString(0);
            reader.Close();
        }

        public void Update()
        {
            string sql = "UPDATE \"Device_type\" " +
                "SET \"name\" = '" + Name + "' " +
                "WHERE \"device_type_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
