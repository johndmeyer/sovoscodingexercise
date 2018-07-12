using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovosCodingExercise.DataModels
{
    public class IngredientDataModel : BaseDataModel
    {
        public int Ingredient_Id { get; set; }

        public string Ingredient_Name { get; set; }

        public string Ingredient_Description { get; set; }
    }
}
