using System.Collections.Generic;
using System.Linq;
using SovosCodingExercise.DataModels;

namespace SovosCodingExercise.DataAccess
{
    public class IngredientData :  BaseDataAccess, IIngredientData
    {
        public IEnumerable<IngredientDataModel> RetrieveIngredients()
        {
            string query = "SELECT * FROM Ingredients;";

            return ExecuteQueryReturnEnumerable<IngredientDataModel>(query).ToList(); ;
        }
    }
}