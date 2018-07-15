using System.Collections.Generic;
using SovosCodingExercise.DataModels;
using SovosCodingExercise.DataAccess;

namespace SovosCodingExercise.BusinessLogic
{
    public class IngredientLogic
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
        /// Returns a list of all available ingredients (for dropdown)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IngredientDataModel> RetrieveIngredients()
        {
            return _ingredientData.RetrieveIngredients();
        }
    }
}