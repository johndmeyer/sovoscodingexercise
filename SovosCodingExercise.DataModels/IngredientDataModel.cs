using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovosCodingExercise.DataModels
{
    public class IngredientDataModel : BaseDataModel
    {
        public int IngredientId { get; set; }

        public string IngredientName { get; set; }

        public string IngredientDescription { get; set; }
    }
}
