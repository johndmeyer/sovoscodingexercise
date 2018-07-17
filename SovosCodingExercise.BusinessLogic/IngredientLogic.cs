using System.Collections.Generic;
using SovosCodingExercise.DataModels;
using SovosCodingExercise.DataAccess;

namespace SovosCodingExercise.BusinessLogic
{
    public class IngredientLogic : IIngredientLogic
    {
        private readonly IIngredientData _ingredientData = null;

        /// <summary>
        /// Ingredient logic constructor
        /// </summary>
        public IngredientLogic()
        {
            _ingredientData = new IngredientData();
        }

        /// <summary>
        /// Ingredient logic constructor for use with ioc
        /// </summary>
        /// <param name="ingredientData"></param>
        public IngredientLogic(IngredientData ingredientData)
        {
            _ingredientData = ingredientData;
        }

        /// <summary>
        /// Writes a new ingredient to the database
        /// </summary>
        /// <param name="ingredientName"></param>
        /// <param name="ingredientDescription"></param>
        /// <returns></returns>
        public  IngredientDataModel CreateIngredient(string ingredientName, string ingredientDescription)
        {
            return _ingredientData.CreateIngredient(ingredientName, ingredientDescription);
        }

        /// <summary>
        /// Returns a single ingredient by id
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <returns></returns>
        public IngredientDataModel RetrieveIngredient(int ingredientId)
        {
            return _ingredientData.RetrieveIngredient(ingredientId);
        }

        /// <summary>
        /// Returns a list of all available ingredients (for dropdown)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IngredientDataModel> RetrieveIngredients()
        {
            return _ingredientData.RetrieveIngredients();
        }

        /// <summary>
        /// Changes an existing ingredient
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <param name="ingredientName"></param>
        /// <param name="ingredientDescription"></param>
        /// <returns></returns>
        public IngredientDataModel UpdateIngredient(int ingredientId, string ingredientName, string ingredientDescription)
        {
            return _ingredientData.UpdateIngredient(ingredientId, ingredientName, ingredientDescription);
        }

        /// <summary>
        /// Deletes an existing ingredient
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <returns></returns>
        public bool DeleteIngredient(int ingredientId)
        {
            return _ingredientData.DeleteIngredient(ingredientId);
        }
    }
}