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
    public class IngredientController : ApiController
    {
        private readonly IngredientLogic _ingredientLogic = null;

        /// <summary>
        /// Comments here
        /// </summary>
        public IngredientController()
        {
            _ingredientLogic = new IngredientLogic();
        }

        // GET api/values
        /// <summary>
        /// Comments here
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

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
