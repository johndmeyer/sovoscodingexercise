using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SovosCodingExercise.DataModels;

namespace SovosCodingExercise.BusinessLogic
{
    public class IngredientLogic
    {
        public IngredientLogic()
        {
        }

        public IEnumerable<IngredientDataModel> RetrieveIngredients()
        {
            return new List<IngredientDataModel>();
        }
    }
}