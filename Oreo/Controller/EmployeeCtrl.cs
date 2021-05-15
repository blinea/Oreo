using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Model;
using Oreo.View;
using System.Data.SqlClient;

namespace Oreo.Controller
{
    class EmployeeCtrl
    {
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string _SQL;

        public static void CreateEmployee(Employee newEmployee)
        {

            try
            {

                _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\bline\\Documents\\Codes\\Visual Studio\\Oreo\\Oreo\\Database\\OreoDB.mdf" + ";Integrated Security=True");


                _connection.Open();

                _SQL = $"insert into Employee(Document, Name, Salary) values ('{newEmployee.Document}', '{newEmployee.Name}', {newEmployee.Salary});";
                _command = new SqlCommand(_SQL, _connection);
                _command.ExecuteNonQuery();

                Alert.showAlert("Se agrego correctamente", ConsoleColor.Green);
            }
            catch (Exception)
            {
                Alert.showAlert("Algo sucedio mal al crear al empleado", ConsoleColor.Red);
            }
            _connection.Close();
            
        }

        public static void ReadEmployee(string documment)
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\bline\\Documents\\Codes\\Visual Studio\\Oreo\\Oreo\\Database\\OreoDB.mdf" + ";Integrated Security=True");

            _connection.Open();
            _SQL = $"select Name, Salary from Employee where Document='{documment}'";
            _command = new SqlCommand(_SQL, _connection);
            SqlDataReader registro = _command.ExecuteReader();
            if (registro.Read())
            {
                Alert.showMessage($"Name: {registro["Name"]}", ConsoleColor.Green);
                Alert.showMessage($"Salary: {registro["Salary"]}", ConsoleColor.Green);
            }
            else
            {
                Alert.showAlert("Ese empleado no se encuentra en la base de datos.", ConsoleColor.Red);
            }
            _connection.Close();
        }

        public static void UpdateEmployee(Employee updatedEmployee)
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\bline\\Documents\\Codes\\Visual Studio\\Oreo\\Oreo\\Database\\OreoDB.mdf" + ";Integrated Security=True");

            _connection.Open();
            _SQL = $"update Employee set Name='{updatedEmployee.Name}', Salary='{updatedEmployee.Salary}' where Document='{updatedEmployee.Document}'";
            _command = new SqlCommand(_SQL, _connection);
            int cant;
            cant = _command.ExecuteNonQuery();

            if (cant == 1)
            {
                Alert.showAlert("Empleado actualizado exitosamente", ConsoleColor.Green);
            }
            else
            {
                Alert.showAlert("Ese empleado no se encuentra en la base de datos.", ConsoleColor.Red);
            }
            _connection.Close();
        }

        public static void DeleteEmployee(string documment)
        {
            _connection.Open();
            _SQL = $"delete from Employee where Document='{documment}'";
            _command = new SqlCommand(_SQL, _connection);
            if (_command.ExecuteNonQuery() == 1)
            {
                Alert.showAlert("Eliminado correctamente", ConsoleColor.Green);
            }
            else
            {
                Alert.showAlert("Ese empleado no se encuentra en la base de datos", ConsoleColor.Red);
            }
            _connection.Close();
        }
    }
}
