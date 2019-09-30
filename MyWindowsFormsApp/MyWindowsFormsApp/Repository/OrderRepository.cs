using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsFormsApp.Repository
{
    public class OrderRepository
    {
        public bool AddOrderInfo(string customerName, string iteamName,int orderQuantity,double totalPrice)
        {
            try
            { // SQL connection 
                string connectionString = @"Server=localhost; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Sql Command

                string commandString = "INSERT INTO Orders(CustomerName,IteamName,OrderQuantity,TotalPrice) VALUES ('" + customerName + "','" + iteamName + "','" + orderQuantity.ToString() + "','" + totalPrice.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();
                if (isExecute > 0)
                {
                    //MessageBox.Show("Successfully Inserted");
                    return true;
                }
                else
                {
                    //MessageBox.Show("Insertion Failed");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
