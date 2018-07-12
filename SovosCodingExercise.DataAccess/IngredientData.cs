using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using SovosCodingExercise.DataModels;
using Dapper;

namespace SovosCodingExercise.DataAccess
{
    public class IngredientData :  BaseDataAccess, IIngredientData
    {
        public IEnumerable<IngredientDataModel> RetrieveIngredients()
        {
            var result = new List<IngredientDataModel>();

            string sqlOrderDetails = "SELECT * FROM Ingredients;";

            using (var connection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                connection.Open();

                result = connection.Query<IngredientDataModel>(sqlOrderDetails).ToList();
            }

            return result;
        }
    }
}