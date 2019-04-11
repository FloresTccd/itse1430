using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Sql
{
    public class SqlGameDatabase : GameDatabase
    {
        public SqlGameDatabase( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        protected override Game AddCore( Game game )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                
                //var cmd = new SqlCommand("",connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddGame";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //add param one way to do it
                var parameter = new SqlParameter("@name",System.Data.SqlDbType.NVarChar);
                parameter.Value = game.Name;
                cmd.Parameters.Add(parameter);

                // add parameter shorter way
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);



                //execute the command 
                //(int)cmd.ExecuteScalar();  // did not work
                // cmd.ExecuteScalar() as int;  //reference types 
                var result = Convert.ToInt32(cmd.ExecuteScalar());

                // returns a id for game
                game.Id = result;
                return game;

            }

            
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }


        protected override void DeleteCore( int id )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "DeleteGame";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                //No results
                cmd.ExecuteNonQuery();
            };

        }

        protected override IEnumerable<Game> GetAllCore()
        {
            var ds = new DataSet();

            using (var conn = GetConnection())
            {
                var cmd = new SqlCommand("GetGames", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                var dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = cmd;

                dataAdapter.Fill(ds);

                //if you wanted to update
                //dataAdapter.Update(ds);

            };

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                return from r in table.Rows.OfType<DataRow>()
                       select new Game() {
                           Id = Convert.ToInt32(r[0]),   //using index. not really a good idea --ordinal,convert
                           Name = r["Name"].ToString(),   //using column name -- by name , convert
                           Description = r.IsNull("description") ? "" : r["description"].ToString(), // to see if the column could be null from db if it is makes it empty string--handels null
                           Price = r.Field<decimal>("Price"), //converts generic decimal from db and converts it to price int
                           Owned = r.Field<bool>("Owned"),  //convert to int than read the boolean 1 being yes to owned
                           Completed = r.Field<bool>("Completed"),

                       };
            };

            return Enumerable.Empty<Game>();


        }

        protected override Game GetCore( int id )
        {
            return GetAllCore().FirstOrDefault(g => g.Id == id);
           
        }

        protected override Game UpdateCore( int id, Game game )
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                //var cmd = new SqlCommand("",connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UpdateGame";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //add param one way to do it
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = game.Name;
                cmd.Parameters.Add(parameter);

                // add parameter shorter way
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);
                cmd.Parameters.AddWithValue("@id", id);

                //No results
                cmd.ExecuteNonQuery();
            };
            return game;


        }
    }
}
