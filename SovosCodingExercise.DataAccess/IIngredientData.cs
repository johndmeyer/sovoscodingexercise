using System;
using System.Collections.Generic;
using SovosCodingExercise.DataModels;

namespace SovosCodingExercise.DataAccess
{
    public interface IIngredientData
    {
        IEnumerable<IngredientDataModel> RetrieveIngredients();
    }
}
