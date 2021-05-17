using System;
using Oreo.Controller;
using Oreo.Model;
using System.Data.SqlClient;
using System.IO;

namespace Oreo.View
{
    class UtilityMenu
    {
        public static void Login()
        {
            string userId = Employee.GetDocument().Document;
            if (EmployeeCtrl.SearchEmployeeDocument(userId))
            {
                Shop.LaunchShopMenu(userId);
            }
            else
            {
                Alert.ShowAlert("User doesn't exist on database.", ConsoleColor.DarkRed);
                Alert.Confirmation();
            }
        }

        public static void LaunchFinishMenu(string userDocument)
        {
            Random random = new Random();
            Order newOrder = new Order(random.Next(10000, 99999), userDocument);
            Alert.ShowAlert(newOrder.ToString(), ConsoleColor.DarkBlue);
            Console.WriteLine("\n");
            ShopCtrl.ShowShoppingCart();
            
            //OrderCtrl.CreateOrder(newOrder);
            OrderCtrl.ReadAllOrders();

        }

        public static void LaunchPrintMenu()
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            com.CommandText = "select Id, Name, Category, Price, Description, Quantity from Product";
            SqlDataReader register = com.ExecuteReader();
            while (register.Read())
            {
                Product myProduct = new Product(register.GetInt32(0), register["Name"].ToString(), register.GetInt32(3), register.GetString(4));
                String path = @"C:\Users\bline\Documents\Codes\Visual Studio\Oreo\Oreo\DataFiles\Products.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(myProduct.ToString2());
                    sr.Close();
                }
            }
            Console.Clear();
            Alert.ShowAlert("Product database printed on text file.", ConsoleColor.Red);
            Alert.Confirmation();
        }
    }
}
