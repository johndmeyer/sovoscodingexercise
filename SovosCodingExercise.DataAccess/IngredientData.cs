using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SovosCodingExercise.DataModels;
using System.Data;

namespace SovosCodingExercise.DataAccess
{
    public class IngredientData
    {
        public IEnumerable<IngredientDataModel> RetrieveIngredients()
        {
            return new List<IngredientDataModel>();


            string sqlOrderDetails = "SELECT TOP 5 * FROM OrderDetails;";

            using (var connection = new System.Data.SqlClient.SqlConnection("Data Source=SqlCe_W3Schools.sdf"))
            {
                var foo = connection.Query
                //var orderDetails = connection.Query<OrderDetail>(sqlOrderDetails).ToList();
                //var orderDetail = connection.QueryFirstOrDefault<OrderDetail>(sqlOrderDetail, new { OrderDetailID = 1 });
                //var affectedRows = connection.Execute(sqlCustomerInsert, new { CustomerName = "Mark" });

                //Console.WriteLine(orderDetails.Count);
                //Console.WriteLine(affectedRows);

                //FiddleHelper.WriteTable(orderDetails);
                //FiddleHelper.WriteTable(new List<OrderDetail>() { orderDetail });
            }
        }
    }
}