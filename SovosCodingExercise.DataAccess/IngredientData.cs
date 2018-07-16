using System.Collections.Generic;
using System.Linq;
using SovosCodingExercise.DataModels;

namespace SovosCodingExercise.DataAccess
{
    public class IngredientData :  BaseDataAccess, IIngredientData
    {
        public IngredientDataModel CreateIngredient(string ingredientName, string ingredientDescription)
        {
            var query = string.Format(
                @"INSERT INTO ingredients VALUES (NEXT VALUE FOR ingredientsSeq, '{0}', '{1}'); 
                 
                SELECT * FROM ingredients ORDER BY ingredientId DESC;", 
                ingredientName, 
                ingredientDescription);

            return ExecuteQueryReturnObject<IngredientDataModel>(query);
        }

        public IngredientDataModel RetrieveIngredient(int ingredientId)
        {
            var query = string.Format("SELECT * FROM Ingredients WHERE IngredientId = {0}", ingredientId);

            return ExecuteQueryReturnObject<IngredientDataModel>(query);
        }

        public IEnumerable<IngredientDataModel> RetrieveIngredients()
        {
            var query = "SELECT * FROM Ingredients;";

            return ExecuteQueryReturnEnumerable<IngredientDataModel>(query).ToList(); ;
        }

        public IngredientDataModel UpdateIngredient(int ingredientId, string ingredientName, string ingredientDescription)
        {
            var query = string.Format(@"UPDATE ingredients SET ingredientName = '{0}', ingredientDescription = '{1}' WHERE ingredientId = {2};", ingredientName, ingredientDescription, ingredientId);

            ExecuteQuery(query);

            return RetrieveIngredient(ingredientId);
        }

        public bool DeleteIngredient(int ingredientId)
        {
            var query = string.Format("DELETE FROM ingredients WHERE ingredientId = {0}", ingredientId);

            ExecuteQuery(query);

            var deletedIngredient = RetrieveIngredient(ingredientId);
                
            return deletedIngredient == null;
        }
    }
}