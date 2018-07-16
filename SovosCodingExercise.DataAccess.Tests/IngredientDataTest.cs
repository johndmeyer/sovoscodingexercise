using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SovosCodingExercise.DataAccess.Tests
{
    [TestClass]
    public class IngredientDataTests
    {
        [TestMethod]
        public void TestCreateIngredient()
        {
            var ingredientData = new IngredientData();

            var result = ingredientData.CreateIngredient("myName", "myDescription");

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestRetrieveIngredient()
        {
            var ingredientData = new IngredientData();

            var result = ingredientData.RetrieveIngredient(1);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestRetrieveIngredients()
        {
            var ingredientData = new IngredientData();

            var result = ingredientData.RetrieveIngredients();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestUpdateIngredient()
        {
            var ingredientData = new IngredientData();

            var result = ingredientData.UpdateIngredient(8, "MyNewName2", "myNewDescription2");

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestDeleteIngredient()
        {
            var ingredientData = new IngredientData();

            var result = ingredientData.DeleteIngredient(5);

            Assert.IsTrue(result);
        } 
    }
}
