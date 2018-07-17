using System;
using System.Collections.Generic;
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
        private readonly IIngredientLogic _ingredientLogic = null;

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
        // TODO: Error Logging

        public IngredientDataModel Put(string ingredientName, string ingredientDescription)
        {
            // Error Handling
            try
            {
                // Validate Inputs
                if (string.IsNullOrEmpty(ingredientName)) { return new IngredientDataModel { ErrorMessage = "IngredientName is a required field." }; }
                if (string.IsNullOrEmpty(ingredientDescription)) { return new IngredientDataModel { ErrorMessage = "IngredientDescription is a required field." }; }

                // Call Business Logic to get data
                return _ingredientLogic.CreateIngredient(ingredientName, ingredientDescription);
            }
            catch (Exception exception)
            {
                // Log Error

                // Return Error
                return new IngredientDataModel { ErrorMessage = "Error occured" };
            }
        }

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
            catch (Exception exception)
            {
                // Log Error

                // Return Error
                return new List<IngredientDataModel> { new IngredientDataModel { ErrorMessage = "Error occured" } };
            }          
        }

        // get api/values/5
        public IngredientDataModel Get(int ingredientId)
        {
            // Error Handling
            try
            {
                // Validate Inputs
                if (ingredientId == null || ingredientId == 0) { return new IngredientDataModel { ErrorMessage = "IngredientId is a required field." }; }

                // Call Business Logic to get data
                return _ingredientLogic.RetrieveIngredient(ingredientId);
            }
            catch (Exception exception)
            {
                // Log Error

                // Return Error
                return new IngredientDataModel { ErrorMessage = "Error occured" };
            }
        }

        // POST api/values
        public IngredientDataModel Post(int ingredientId, string ingredientName, string ingredientDescription)
        {
            try
            {
                // Validate Inputs
                if (ingredientId == null || ingredientId == 0) { return new IngredientDataModel { ErrorMessage = "IngredientId is a required field." }; }                
                if (string.IsNullOrEmpty(ingredientName)) { return new IngredientDataModel { ErrorMessage = "IngredientName is a required field." }; }
                if (string.IsNullOrEmpty(ingredientDescription)) { return new IngredientDataModel { ErrorMessage = "IngredientDescription is a required field." }; }

                // Call Business Logic to get data
                return _ingredientLogic.UpdateIngredient(ingredientId, ingredientName, ingredientDescription);
            }
            catch (Exception exception)
            {
                // Log Error

                // Return Error
                return new IngredientDataModel { ErrorMessage = "Error occured" };
            }
        }

        // DELETE api/values/5
        public BaseDataModel Delete(int ingredientId)
        {
            try
            {
                // Validate Inputs
                if (ingredientId == null || ingredientId == 0) { return new IngredientDataModel { ErrorMessage = "IngredientId is a required field." }; }

                // Call Business Logic to get data
                return _ingredientLogic.DeleteIngredient(ingredientId) == true
                    ? new BaseDataModel()
                    : new BaseDataModel { ErrorMessage = "Error occured" };
            }
            catch (Exception exception)
            {
                // Log Error

                // Return Error
                return new BaseDataModel { ErrorMessage = "Error occured" };
            }
        }
    }
}
