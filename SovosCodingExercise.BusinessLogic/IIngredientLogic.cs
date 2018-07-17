using SovosCodingExercise.DataModels;
using System.Collections.Generic;


namespace SovosCodingExercise.BusinessLogic
{
    public interface IIngredientLogic
    {
        /// <summary>
        /// Writes a new ingredient to the database
        /// </summary>
        /// <param name="ingredientName"></param>
        /// <param name="ingredientDescription"></param>
        /// <returns></returns>
        IngredientDataModel CreateIngredient(string ingredientName, string ingredientDescription);

        /// <summary>
        /// Returns a single ingredient by id
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <returns></returns>
        IngredientDataModel RetrieveIngredient(int ingredientId);

        /// <summary>
        /// Returns a list of all available ingredients (for dropdown)
        /// </summary>
        /// <returns></returns>
        IEnumerable<IngredientDataModel> RetrieveIngredients();

        /// <summary>
        /// Changes an existing ingredient
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <param name="ingredientName"></param>
        /// <param name="ingredientDescription"></param>
        /// <returns></returns>
        IngredientDataModel UpdateIngredient(int ingredientId, string ingredientName, string ingredientDescription);

        /// <summary>
        /// Deletes an existing ingredient
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <returns></returns>
        bool DeleteIngredient(int ingredientId);
    }
}
