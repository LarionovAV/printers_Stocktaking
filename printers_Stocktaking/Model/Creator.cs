using Npgsql;
namespace printers_Stocktaking.Model
{
    class Creator : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public Creator() { }
        public Creator(string name) {
            Name = name.Trim(); 
        }
        public Creator(int id, string name = "") : this(name){
            ID = id;
        }

        public void Create()
        {
            string sql = "INSERT INTO \"Creator\"(\"name\") " +
                "VALUES ('" + Name + "') RETURNING \"creator_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql = "DELETE FROM \"Creator\" " +
                "WHERE \"creator_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql = "SELECT \"name\" FROM \"Creator\" WHERE \"creator_ID\" = " + ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            Name = reader.GetString(0);
            reader.Close();
        }

        public void Update()
        {
            string sql = "UPDATE \"Creator\" " +
                "SET \"name\" = '" + Name + "' " +
                "WHERE \"creator_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
