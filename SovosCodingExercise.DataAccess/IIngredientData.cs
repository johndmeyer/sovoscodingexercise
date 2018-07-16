using System;
using System.Collections.Generic;
using SovosCodingExercise.DataModels;

namespace SovosCodingExercise.DataAccess
{
    public interface IIngredientData
    {
        IngredientDataModel CreateIngredient(string ingredientName, string ingredientDescription);

        IngredientDataModel RetrieveIngredient(int ingredientId);

        IEnumerable<IngredientDataModel> RetrieveIngredients();

        IngredientDataModel UpdateIngredient(int ingredientId, string ingredientName, string ingredientDescription);

        bool DeleteIngredient(int ingredientId);
    }
}
