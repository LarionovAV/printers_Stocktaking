using Npgsql;

namespace printers_Stocktaking.Model
{
    class Material : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public int Available { get; set; }
        public int Measure { get; set; }

        public Material() { }
        public Material(
            string name,
            int available,
            int measure) : this()
        {
            Name = name.Trim();
            Available = available;
            Measure = measure;
        }
        public Material(
            int id,
           string name,
            int available,
            int measure) : this(name, available, measure)
        {
            ID = id;
        }

        public void Create()
        {
            string sql =
                "INSERT INTO \"Material\"(\"name\", \"available\", \"measure_ID\") " +
                "VALUES ('" + Name.Trim() + "', " + Available + ", " + Measure + ") returning \"material_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql =
                            "DELETE FROM \"Material\" WHERE \"material_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql =
                "SELECT \"name\", \"available\", \"measure_ID\" " +
                "FROM \"Material\" " +
                "WHERE \"material_ID\" = " + ID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();

            reader.Read();
            Name = reader.GetString(0);
            Available = reader.GetInt32(1);
            Measure = reader.GetInt32(2);
            reader.Close();
        }

        public void Update()
        {
            string sql =
                "UPDATE \"Material\" " +
                "SET \"name\" = '" + Name + "', \"available\" = " + Available + ", measure_ID = " + Measure +
                "WHERE \"material_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
