using Npgsql;

namespace printers_Stocktaking.Model
{
    class PrinterModel : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public int CreatorID { get; private set; }

        public PrinterModel() { }
        public PrinterModel(string name, int creator_id)
        {
            Name = name.Trim();
            CreatorID = creator_id;
        }
        public PrinterModel(int id, string name, int creator_id) : this(name, creator_id)
        {
            ID = id;
        }

        public void Create()
        {
            string sql = "INSERT INTO \"Device_model\"(\"name\", \"creator_ID\") " +
                "VALUES ('" + Name + "', " + CreatorID + ") RETURNING \"model_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql = "DELETE FROM \"Device_model\" " +
                "WHERE \"model_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql = "SELECT \"name\", \"creator_id\" FROM \"Device_model\" WHERE \"model_ID\" = " + ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            Name = reader.GetString(0);
            CreatorID = reader.GetInt32(1);
            reader.Close();
        }

        public void Update()
        {
            string sql = "UPDATE \"Device_model\" " +
                "SET \"name\" = '" + Name + "', \"creator_ID\" = " + CreatorID + " " +
                "WHERE \"model_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
