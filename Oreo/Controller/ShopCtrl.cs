using System;
using System.Data.SqlClient;
using Oreo.View;
using Oreo.Model;
using System.IO;

namespace Oreo.Controller
{
    class ShopCtrl
    {
        public static void GetProduct(int id, string user)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            int xid = id;
            com.CommandText = "select Id, Name, Category, Price, Description, Quantity from Product where Id = (@id);";
            com.Parameters.AddWithValue("id", xid);
            try
            {
                SqlDataReader register = com.ExecuteReader();
                if (register.Read())
                {
                    Console.Write("\n");
                    Alert.ShowMessage($"Product Added to Shopping Cart", ConsoleColor.Blue);
                    Alert.ShowMessage($"---------------------------------------", ConsoleColor.Blue);
                    Product myProduct = new Product(register.GetInt32(0), register["Name"].ToString(), register.GetInt32(3), register.GetString(4));
                    Alert.ShowMessage(myProduct.ToString2(), ConsoleColor.DarkGreen);

                    String path = @"C:\Users\bline\Documents\Codes\Visual Studio\Oreo\Oreo\DataFiles\ShoppingCart.txt";

                    using (StreamWriter sr = File.AppendText(path))
                    {
                        sr.WriteLine(myProduct.ToString2());
                        sr.Close();
                    }
                }
                else
                {
                    Alert.ShowAlert("Product doesn't exist on database.", ConsoleColor.Red);
                }
            }
            catch (Exception)
            {
                Alert.ShowAlert("Database Error", ConsoleColor.Red);
            }
        }

        public static void ShowShoppingCart()
        {
            String path = @"C:\Users\bline\Documents\Codes\Visual Studio\Oreo\Oreo\DataFiles\ShoppingCart.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                int count = 1;

                while ((s = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(s) || !string.IsNullOrWhiteSpace(s))
                    {
                        Alert.ShowMessage("------------------------------------------------------------------------------", ConsoleColor.DarkCyan);
                        Alert.ShowMessage(count + "|" + s, ConsoleColor.DarkGreen);
                        count++;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
        }

        public static void RemoveProduct(int lineNumber)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\bline\Documents\Codes\Visual Studio\Oreo\Oreo\DataFiles\ShoppingCart.txt");
            string newstr = null;
            while ((line = file.ReadLine()) != null)
            {
                
                if ((counter + 1).Equals(lineNumber))
                {
                    if (!string.IsNullOrEmpty(line) || !string.IsNullOrWhiteSpace(line))
                    {                      
                        line.Remove(lineNumber);
                        Alert.ShowAlert("Item Removed From Cart", ConsoleColor.DarkGreen);
                    }
                    else
                    {
                        counter++;
                        Alert.ShowAlert("Invalid item number", ConsoleColor.DarkRed);
                    }
                    
                }
                else
                {
                    newstr += line + Environment.NewLine;
                }
                counter++;
            }

            file.Close();

            if (System.IO.File.Exists(@"C:\Users\bline\Documents\Codes\Visual Studio\Oreo\Oreo\DataFiles\ShoppingCart.txt"))
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Users\bline\Documents\Codes\Visual Studio\Oreo\Oreo\DataFiles\ShoppingCart.txt");
                sw.WriteLine(newstr);
                sw.Close();
            }

        }
    }
}
