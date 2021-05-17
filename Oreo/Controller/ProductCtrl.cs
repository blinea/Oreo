using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Model;
using Oreo.View;
using System.Data.SqlClient;
using System.IO;

namespace Oreo.Controller
{
    internal class ProductCtrl
    {
        public static void CreateProduct(Product newProduct)
        {
            try
            {
                ProyectConnection NewConnection = new ProyectConnection();
                NewConnection.ConnectToday();
                SqlCommand com = new SqlCommand();
                com.Connection = ProyectConnection.conn;
                com.CommandText = "insert into Product(Id, Name, Category, Price, Description, Quantity) values (@id, @name, @cate, @price, @desc, @quan);";
                com.Parameters.AddWithValue("id", newProduct.Id);
                com.Parameters.AddWithValue("name", newProduct.Name);
                com.Parameters.AddWithValue("cate", newProduct.Category);
                com.Parameters.AddWithValue("price", newProduct.Price);
                com.Parameters.AddWithValue("desc", newProduct.Description);
                com.Parameters.AddWithValue("quan", newProduct.Quantity);
                com.ExecuteNonQuery();
                Alert.ShowAlert("Product Saved on Database.", ConsoleColor.Green);
            }
            catch (Exception)
            {
                Alert.ShowAlert("Something is wrong, Product couldn't be saved.", ConsoleColor.Red);
            }
        }

        

        public static void ReadProduct(int id)
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
                    Alert.ShowMessage($"Product Found", ConsoleColor.Blue);
                    Alert.ShowMessage($"---------------------------------------", ConsoleColor.Blue);
                    Alert.ShowMessage($"ID: {register["Id"]}", ConsoleColor.Blue);
                    Alert.ShowMessage($"Name: {register["Name"]}", ConsoleColor.Blue);
                    Alert.ShowMessage($"Category: {register["Category"]}", ConsoleColor.Blue);
                    Alert.ShowMessage($"Price: {register["Price"]}", ConsoleColor.Blue);
                    Alert.ShowMessage($"Description: {register["Description"]}", ConsoleColor.Blue);
                    Alert.ShowMessage($"Quantity: {register["Quantity"]}", ConsoleColor.Blue);
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

        public static void ReadAllProducts()
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            com.CommandText = "select Id, Name, Category, Price, Description, Quantity from Product";
            SqlDataReader register = com.ExecuteReader();
            while (register.Read())
            {
                Alert.ShowMessage($"----------------------------", ConsoleColor.DarkCyan);
                Alert.ShowMessage($"ID: {register["Id"]}", ConsoleColor.Blue);
                Alert.ShowMessage($"Name: {register["Name"]}", ConsoleColor.Blue);
                //Alert.showMessage($"Category: {register["Category"]}", ConsoleColor.Blue);
                Alert.ShowMessage($"Price: {register["Price"]}", ConsoleColor.Blue);
                Alert.ShowMessage($"Description: {register["Description"]}", ConsoleColor.Blue);
                //Alert.showMessage($"Quantity: {register["Quantity"]}", ConsoleColor.Blue);
            }
        }

        public static void UpdateProduct(Product updatedProduct)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            com.CommandText = "update Product set Name=(@name), Category=(@cate), Price=(@price), Description=(@desc), Quantity=(@quan) where Id=(@id)";
            com.Parameters.AddWithValue("name", updatedProduct.Name);
            com.Parameters.AddWithValue("cate", updatedProduct.Category);
            com.Parameters.AddWithValue("price", updatedProduct.Price);
            com.Parameters.AddWithValue("desc", updatedProduct.Description);
            com.Parameters.AddWithValue("quan", updatedProduct.Quantity);
            com.Parameters.AddWithValue("id", updatedProduct.Id);
            int cant;
            cant = com.ExecuteNonQuery();
            if (cant == 1)
            {
                Alert.ShowAlert("Product updated successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.ShowAlert("Product doesn't exist on database.", ConsoleColor.Red);
            }
        }

        public static void DeleteProduct(int id)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            int xid = id;
            com.CommandText = "delete from Product where Id=(@id)";
            com.Parameters.AddWithValue("id", xid);
            if (com.ExecuteNonQuery() == 1)
            {
                Alert.ShowAlert("Product deleted successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.ShowAlert("Product doesn't exist on database.", ConsoleColor.Red);
            }
        }
    }
}
