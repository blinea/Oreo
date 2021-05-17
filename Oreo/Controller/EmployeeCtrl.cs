using Oreo.Model;
using Oreo.View;
using System;
using System.Data.SqlClient;

namespace Oreo.Controller
{
    internal class EmployeeCtrl
    {
        public static void CreateEmployee(Employee newEmployee)
        {
            try
            {
                ProyectConnection NewConnection = new ProyectConnection();
                NewConnection.ConnectToday();
                SqlCommand com = new SqlCommand();
                com.Connection = ProyectConnection.conn;
                com.CommandText = "insert into Employee(Document, Name, Address) values (@doc, @name, @add);";
                com.Parameters.AddWithValue("doc", newEmployee.Document);
                com.Parameters.AddWithValue("name", newEmployee.Name);
                com.Parameters.AddWithValue("add", newEmployee.Address);
                com.ExecuteNonQuery();
                Alert.ShowAlert("Client Saved on Database.", ConsoleColor.Green);
            }
            catch (Exception)
            {
                Alert.ShowAlert("Something is wrong, client couldn't be saved.", ConsoleColor.Red);
            }
        }

        public static void ReadEmployee(string document)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            string xdoc = document;
            com.CommandText = "select Name, Address from Employee where Document = (@doc);";
            com.Parameters.AddWithValue("doc", xdoc);
            try
            {
                SqlDataReader register = com.ExecuteReader();
                if (register.Read())
                {
                    Console.Write("\n");
                    Alert.ShowMessage($"Client Found", ConsoleColor.Blue);
                    Alert.ShowMessage($"---------------------------------------", ConsoleColor.Blue);
                    Alert.ShowMessage($"Name: {register["Name"]}", ConsoleColor.Blue);
                    Alert.ShowMessage($"Address: {register["Address"]}", ConsoleColor.Blue);
                }
                else
                {
                    Alert.ShowAlert("Client doesn't exist on database.", ConsoleColor.Red);
                }
            }
            catch (Exception)
            {
                Alert.ShowAlert("Database Error", ConsoleColor.Red);
            }
        }

        public static bool SearchEmployeeDocument(string document)
        {
            bool exists = false;
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            string xdoc = document;
            com.CommandText = "select Name, Address from Employee where Document = (@doc);";
            com.Parameters.AddWithValue("doc", xdoc);

            try
            {
                SqlDataReader register = com.ExecuteReader();
                if (register.Read())
                {
                    exists = true;
                    return exists;
                }
                else
                {
                    Alert.ShowAlert("Client doesn't exist on database.", ConsoleColor.Red);
                    return exists;                  
                }
            }
            catch (Exception)
            {
                Alert.ShowAlert("Database Error", ConsoleColor.Red);
                return exists;
            }
        }

        public static void ReadAllEmployees ()
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            com.CommandText = "select Document, Name, Address from Employee";
            SqlDataReader register = com.ExecuteReader();
            while (register.Read())
            {
                Alert.ShowMessage($"----------------------------", ConsoleColor.DarkCyan);
                Alert.ShowMessage($"Document: {register["Document"]}", ConsoleColor.Blue);
                Alert.ShowMessage($"Name: {register["Name"]}", ConsoleColor.Blue);
                Alert.ShowMessage($"Address: {register["Address"]}", ConsoleColor.Blue);
            }
        }

        public static void UpdateEmployee(Employee updatedEmployee)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            com.CommandText = "update Employee set Name=(@name), Address=(@add) where Document=(@doc)";
            com.Parameters.AddWithValue("name", updatedEmployee.Name);
            com.Parameters.AddWithValue("add", updatedEmployee.Address);
            com.Parameters.AddWithValue("doc", updatedEmployee.Document);
            int cant;
            cant = com.ExecuteNonQuery();
            if (cant == 1)
            {
                Alert.ShowAlert("Client updated successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.ShowAlert("Product doesn't exist on database.", ConsoleColor.Red);
            }
        }

        public static void DeleteEmployee(string documment)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();
            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;
            string xdoc = documment;
            com.CommandText = "delete from Employee where Document=(@doc)";
            com.Parameters.AddWithValue("doc", xdoc);
            if (com.ExecuteNonQuery() == 1)
            {
                Alert.ShowAlert("Client deleted successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.ShowAlert("Client doesn't exist on database.", ConsoleColor.Red);
            }
        }
    }
}