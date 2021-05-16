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

                com.CommandText = "insert into Employee(Document, Name, Salary) values (@doc, @name, @sal);";
                com.Parameters.AddWithValue("doc", newEmployee.Document);
                com.Parameters.AddWithValue("name", newEmployee.Name);
                com.Parameters.AddWithValue("sal", newEmployee.Salary);
                com.ExecuteNonQuery();

                Alert.showAlert("Client Saved on Database.", ConsoleColor.Green);
            }
            catch (Exception)
            {
                Alert.showAlert("Something is wrong, client couldn't be saved.", ConsoleColor.Red);
            }
        }

        public static void ReadEmployee(string documment)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();

            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;

            string xdoc = documment;

            com.CommandText = "select Name, Salary from Employee where Document = (@doc);";
            com.Parameters.AddWithValue("doc", xdoc);

            try
            {
                SqlDataReader register = com.ExecuteReader();
                if (register.Read())
                {
                    Alert.showMessage($"Name: {register["Name"]}", ConsoleColor.Blue);
                    Alert.showMessage($"Salary: {register["Salary"]}", ConsoleColor.Blue);
                }
                else
                {
                    Alert.showAlert("Client doesn't exist on database.", ConsoleColor.Red);
                }
            }
            catch (Exception)
            {
                Alert.showAlert("Database Error", ConsoleColor.Red);
            }
        }

        public static void UpdateEmployee(Employee updatedEmployee)
        {
            ProyectConnection NewConnection = new ProyectConnection();
            NewConnection.ConnectToday();

            SqlCommand com = new SqlCommand();
            com.Connection = ProyectConnection.conn;

            com.CommandText = "update Employee set Name=(@name), Salary=(@sal) where Document=(@doc)";
            com.Parameters.AddWithValue("name", updatedEmployee.Name);
            com.Parameters.AddWithValue("sal", updatedEmployee.Salary);
            com.Parameters.AddWithValue("doc", updatedEmployee.Document);

            int cant;
            cant = com.ExecuteNonQuery();

            if (cant == 1)
            {
                Alert.showAlert("Client updated successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.showAlert("Product doesn't exist on database.", ConsoleColor.Red);
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
                Alert.showAlert("Client deleted successfully.", ConsoleColor.Green);
            }
            else
            {
                Alert.showAlert("Client doesn't exist on database.", ConsoleColor.Red);
            }
        }
    }
}