using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SovosCodingExercise.DataAccess.Tests
{
    [TestClass]
    public class IngredientDataTests
    {
        [TestMethod]
        public void TestRetrieveIngredients()
        {
            var ingredientData = new IngredientData();

            var result = ingredientData.RetrieveIngredients();

            Assert.IsNotNull(result);
        }      
    }
}
