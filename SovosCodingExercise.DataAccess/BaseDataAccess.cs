using System;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace SovosCodingExercise.DataAccess
{
    public class BaseDataAccess
    {
        protected string _connectionString = "Data Source=localhost;Initial Catalog=Recipes;User ID=sa;Password=abc123";

        protected IEnumerable<T> ExecuteQueryReturnEnumerable<T>(string query)
        {
            var result = new List<T>();

            using (var connection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                connection.Open();

                result = connection.Query<T>(query).ToList();
            }

            return result;
        }

        protected T ExecuteQueryReturnObject<T>(string query)
        {
            var result = Activator.CreateInstance<T>();

            using (var connection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                connection.Open();

                result = connection.Query<T>(query).FirstOrDefault();
            }

            return result;
        }
    }
}
