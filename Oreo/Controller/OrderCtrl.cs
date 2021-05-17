using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Model;
using System.Data.SqlClient;
using Oreo.View;
using System.Linq;
using System.Threading.Tasks;

namespace Oreo.Controller
{
    class OrderCtrl
    {
        //TO DO---------------------------

        public static void CreateOrder(Order newOrder)
        {
            try
            {
                ProyectConnection NewConnection = new ProyectConnection();
                NewConnection.ConnectToday();
                SqlCommand com = new SqlCommand();
                com.Connection = ProyectConnection.conn;
                com.CommandText = "insert into Order values (@id, @doc)";
                com.Parameters.AddWithValue("@id", newOrder.Id);
                com.Parameters.AddWithValue("@doc", newOrder.ClientDocument);
                com.ExecuteNonQuery();
                Alert.ShowAlert("Order Saved on Database.", ConsoleColor.Green);               
            }
            catch (Exception)
            {
                Alert.ShowAlert("Something is wrong, Order couldn't be saved.", ConsoleColor.Red);
            }
        }

        public static void ReadAllOrders()
        {
            List<Order> orders = new List<Order>();
            Random random = new Random();

            orders.Add(new Order(random.Next(10000, 99999), random.Next(200, 300).ToString()));
            orders.Add(new Order(random.Next(10000, 99999), random.Next(200, 300).ToString()));
            orders.Add(new Order(random.Next(10000, 99999), random.Next(200, 300).ToString()));
            orders.Add(new Order(random.Next(10000, 99999), random.Next(200, 300).ToString()));
            orders.Add(new Order(random.Next(10000, 99999), random.Next(200, 300).ToString()));
            orders.Add(new Order(random.Next(10000, 99999), random.Next(200, 300).ToString()));
            orders.Add(new Order(random.Next(10000, 99999), random.Next(200, 300).ToString()));

            var orderByResult = from s in orders
                                orderby s.Id ascending
                                select s;

            Console.WriteLine("\n");
            Alert.ShowMessage("          ---------Past Orders--------", ConsoleColor.DarkYellow);
            foreach (var item in orderByResult)
            {
                Console.WriteLine("\n"+item);

            }
        }
    }
}
