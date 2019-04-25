/*
    Lab 4 ITSE1430
    Raul Flores
    April 29, 2019
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlDatabase : IProductDatabase
    {
        public SqlDatabase( string connectionString )
        {
            _connectionString = connectionString;
        }
        private readonly string _connectionString;

        public Product Add( Product product )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameter 1 - long way when you need control over parameter
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = product.Name;
                cmd.Parameters.Add(parameter);

                //Add parameter 2 - quick way when you just need type/value
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);


                // (int)cmd.ExecuteScalar();
                // cmd.ExecuteScalar() as int;  //reference types 
                var result = Convert.ToInt32(cmd.ExecuteScalar());

                product.Id = result;
                return product;

            }
        }

        public Product Get( int id )
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetAllProducts";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var gameId = reader.GetInt32(0);
                    if (gameId == id)
                    {
                        return new Product() {
                            Id = gameId,
                            Name = GetString(reader, "Name"),
                            Description = GetString(reader, "Description"),
                            Price = reader.GetFieldValue<decimal>(3),
                            IsDiscontinued = Convert.ToBoolean(reader.GetValue(4))
                          
                        };
                    };
                };
            };

            return null;
        }

        public IEnumerable<Product> GetAll()
        {
            var ds = new DataSet();

            using (var conn = GetConnection())
            {
                var cmd = new SqlCommand("GetAllProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds);

            };


            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                return from r in table.Rows.OfType<DataRow>()
                       select new Product() {
                           Id = Convert.ToInt32(r[0]),  //Ordinal, convert
                           Name = r["Name"].ToString(), //By name, convert
                           Price = r.Field<decimal>("Price"),
                           Description = r.IsNull("description") ? "" : r["description"].ToString(), //handle DB nulls
                           IsDiscontinued = r.Field<bool>("IsDiscontinued"),
                       };
            };

            return Enumerable.Empty<Product>();


        }

        public void Remove( int id )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "RemoveProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                //No results
                cmd.ExecuteNonQuery();
            };
        }

        public Product Update( Product product )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UpdateProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameter 1 - long way when you need control over parameter
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = product.Name;
                cmd.Parameters.Add(parameter);

                //Add parameter 2 - quick way when you just need type/value
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);
                cmd.Parameters.AddWithValue("@id", product.Id);

                //No results
                cmd.ExecuteNonQuery();
            };

            return product;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }


        private string GetString( IDataReader reader, string name )
        {
            var ordinal = reader.GetOrdinal(name);

            if (reader.IsDBNull(ordinal))
                return "";

            return reader.GetString(ordinal);
        }

    }
}
