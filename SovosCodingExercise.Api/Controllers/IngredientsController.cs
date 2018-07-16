using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SovosCodingExercise.BusinessLogic;
using SovosCodingExercise.DataModels;

namespace SovosCodingExercise.Api.Controllers
{
    /// <summary>
    /// Need comments here
    /// </summary>
    public class IngredientsController : ApiController
    {
        private readonly IngredientLogic _ingredientLogic = null;

        /// <summary>
        /// Comments here
        /// </summary>
        public IngredientsController()
        {
            _ingredientLogic = new IngredientLogic();
        }

        /// <summary>
        /// Ingredient controller constructor - for use with ioc
        /// </summary>
        /// <param name="ingredientLogic"></param>
        public IngredientsController(IngredientLogic ingredientLogic)
        {
            _ingredientLogic = ingredientLogic;
        }

        // TODO: Authentication

        /// <summary>
        /// Returns a list of all available ingredients (for dropdown)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IngredientDataModel> Get()
        {
            // Error Handling
            try
            {
                // Validate Inputs

                // Call Business Logic to get data
                return _ingredientLogic.RetrieveIngredients();
            }
            catch
            {
                // Log Error

                // Return Error
                return new List<IngredientDataModel> { new IngredientDataModel { ErrorMessage = "Error occured" } };
            }          
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        public IngredientDataModel Put(string ingredientName, string ingredientDescription)
        {
            // Error Handling
            try
            {
                // Validate Inputs

                // Call Business Logic to get data
                //return _ingredientLogic.RetrieveIngredients();
            }
            catch (Exception exception)
            {
                // Log Error

                // Return Error
                //return new List<IngredientDataModel> { new IngredientDataModel { ErrorMessage = "Error occured" } };
            }

            return new IngredientDataModel();
        }

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
