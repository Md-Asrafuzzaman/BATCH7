using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsFormsApp.Repository
{
    public class CustomerRepository
    {
        public bool AddCustomerInfo(string name,string address,string contact)
        {
            bool isAdded = false;
            try
            { // SQL connection 
                string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Sql Command

                string commandString = "INSERT INTO Customer(CustomerName,CustomerAddress,CustomerContact) VALUES ('" + name + "','" + address + "','" + contact + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();
                if (isExecute > 0)
                {
                    isAdded = true;
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
            return isAdded;
        }

        public bool IsNameExists(string name)
        {
            bool exists = false;
              //Connection
                string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE CustomerName ='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            return exists;
        }

        public bool UpdateCustomerInfo(int id,string name, string address, string contact)
        {
            try
            {// SQL connection 
                string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Sql Command

                string commandString = @"UPDATE Customer SET CustomerName ='" + name + "', CustomerAddress = '" + address + "',CustomerContact = '" + contact + "' WHERE CustomerId ='" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();
                if (isExecute > 0)
                {
                    return true;
                }
                else
                {
                    //MessageBox.Show("Updated Failed");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return true;
        }

        public DataTable Display()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                //showDataGridView.DataSource = dataTable;
            }
            else
            {
                // MessageBox.Show("No Data Found");
            }

            //Close
            sqlConnection.Close();
            return dataTable;

        }
    }
}
