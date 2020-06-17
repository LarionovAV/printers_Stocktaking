using Npgsql;
using System;

namespace printers_Stocktaking.Model
{
    class Department : IDbEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Parent { get; private set; }


        public Department() { }
        public Department(
            string name, 
            string parent_ID) {
            Name = name.Trim();
            Parent = parent_ID;
        }
        public Department(
            int id, 
            string name = "", 
            string parent_ID = "") : this(name, parent_ID)
        {
            ID = id;
        }

        public void Create()
        {
            string sql =
                       "INSERT INTO \"Department\"(\"name\", \"parent_dep_ID\") " +
                       "VALUES ('" + Name + "', " + Parent + ") returning \"dep_ID\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            ID = reader.GetInt32(0);
            reader.Close();
        }

        public void Delete()
        {
            string sql =
                       "DELETE FROM \"Department\" " +
                       "WHERE \"dep_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public void Find(int id)
        {
            ID = id;
            string sql =
                       "SELECT * FROM \"Department\" " +
                       "WHERE \"dep_ID\" = " + id;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            Name = reader["name"].ToString();

            Parent = reader["parent_dep_ID"].ToString().ToUpper();
            reader.Close();
        }

        public void Update()
        {
            string sql =
                       "UPDATE \"Department\" " +
                       "SET \"name\" = '" + Name + "', \"parent_dep_ID\" = " + Parent + 
                       " WHERE \"dep_ID\" = " + ID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
