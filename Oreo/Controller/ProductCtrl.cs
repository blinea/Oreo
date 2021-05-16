using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Model;
using Oreo.View;
using System.Data.SqlClient;

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

                Alert.showAlert("Product Saved on Database.", ConsoleColor.Green);
            }
            catch (Exception)
            {
                Alert.showAlert("Something is wrong, Product couldn't be saved.", ConsoleColor.Red);
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
                    Alert.showMessage($"ID: {register["Id"]}", ConsoleColor.Blue);
                    Alert.showMessage($"Name: {register["Name"]}", ConsoleColor.Blue);
                    Alert.showMessage($"Category: {register["Category"]}", ConsoleColor.Blue);
                    Alert.showMessage($"Price: {register["Price"]}", ConsoleColor.Blue);
                    Alert.showMessage($"Description: {register["Description"]}", ConsoleColor.Blue);
                    Alert.showMessage($"Quantity: {register["Quantity"]}", ConsoleColor.Blue);
                }
                else
                {
                    Alert.showAlert("Product doesn't exist on database.", ConsoleColor.Red);
                }
            }
            catch (Exception)
            {
                Alert.showAlert("Database Error", ConsoleColor.Red);
            }
        }

        public static void ReadAllProducts()
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();

            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;

            List<Product> products = new List<Product>();
            com.CommandText = "select Id, Name, Category, Price, Description, Quantity from Product";
            SqlDataReader register = com.ExecuteReader();
            while (register.Read())
            {
                Alert.showMessage($"----------------------------", ConsoleColor.DarkCyan);
                Alert.showMessage($"ID: {register["Id"]}", ConsoleColor.Blue);
                Alert.showMessage($"Name: {register["Name"]}", ConsoleColor.Blue);
                //Alert.showMessage($"Category: {register["Category"]}", ConsoleColor.Blue);
                Alert.showMessage($"Price: {register["Price"]}", ConsoleColor.Blue);
                Alert.showMessage($"Description: {register["Description"]}", ConsoleColor.Blue);
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
                Alert.showAlert("Product updated successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.showAlert("Product doesn't exist on database.", ConsoleColor.Red);
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
                Alert.showAlert("Product deleted successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.showAlert("Product doesn't exist on database.", ConsoleColor.Red);
            }
        }

    }
}
