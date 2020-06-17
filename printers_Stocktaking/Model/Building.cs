using Npgsql;
using System;

namespace printers_Stocktaking.Model
{
    class Building : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public Building() { }
        public Building(
            string name, 
            string short_name) {
            Name = name.Trim();
            ShortName = short_name.Trim();
        }
        public Building(
            int id,
            string name = "",
            string short_name = "") : this(name, short_name)
        {
            ID = id;
        }

        public void Create()
        {
            string sql =
                "INSERT INTO \"Building\"(\"name\", \"short_name\") " +
                "VALUES ('" + Name.Trim() + "', '" + ShortName.Trim() + "') " + "returning \"building_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql =
                "DELETE FROM \"Building\" WHERE \"building_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Update()
        {
            string sql =
                "UPDATE \"Building\" " +
                "SET \"name\" = '" + Name + "', \"short_name\" = '" + ShortName + "' " +
                "WHERE \"building_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql =
                "SELECT \"name\", \"short_name\" " +
                "FROM \"Building\" " +
                "WHERE \"building_ID\" = " + ID;
            NpgsqlDataReader reader =  new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();

            reader.Read();
            Name = reader.GetString(0);
            ShortName = reader.GetString(1);
            reader.Close();
        }
    }
}
