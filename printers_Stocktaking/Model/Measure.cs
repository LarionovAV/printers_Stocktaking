using Npgsql;

namespace printers_Stocktaking.Model
{
    class Measure : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get;  set; }
        public string ShortName { get;  set; }

        public Measure() { }
        public Measure(
            string name,
            string short_name) :this()
        {
            Name = name.Trim();
            ShortName = short_name.Trim();
        }
        public Measure(
            int id,
            string name = "",
            string short_name = "") : this(name, short_name)
        {
            ID = id;
        }

        public void Create()
        {
            string sql =
                "INSERT INTO \"Measure\"(\"name\", \"short_name\") " +
                "VALUES ('" + Name.Trim() + "', '" + ShortName.Trim() + "') " + "returning \"measure_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql =
                            "DELETE FROM \"Measure\" WHERE \"measure_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql =
                "SELECT \"name\", \"short_name\" " +
                "FROM \"Measure\" " +
                "WHERE \"measure_ID\" = " + ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();

            reader.Read();
            Name = reader.GetString(0);
            ShortName = reader.GetString(1);
            reader.Close();
        }

        public void Update()
        {
            string sql =
                "UPDATE \"Measure\" " +
                "SET \"name\" = '" + Name + "', \"short_name\" = '" + ShortName + "' " +
                "WHERE \"measure_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
