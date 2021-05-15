using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Oreo.Model;

namespace Oreo.View
{
    class App
    {
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string _SQL;

        public static void InitializeApp()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\bline\\Documents\\Codes\\Visual Studio\\Oreo\\Oreo\\Database\\OreoDB.mdf" + ";Integrated Security=True");
            LaunchMenu();
        }

        public static void LaunchMenu()
        {
            char opt = '0';
            Console.WriteLine("\n\t(1) Create (2) Read (3) Update (4) Delete (5) Exit");
            Console.Write("\n\tWhat you want to do? ");
            opt = char.Parse(Console.ReadLine());
            switch (opt)
            {
                case '1':
                    try
                    {
                        CreateEmployee(Employee.getAllInfo());
                    }
                    catch (ApplicationException error)
                    {
                        Alert.showAlert(error.Message, ConsoleColor.Red);
                        InitializeApp();
                    }
                    break;
                case '2':
                    try
                    {
                        ReadEmployee(Employee.getDocument().Document);
                    }
                    catch (ApplicationException error)
                    {
                        Alert.showAlert(error.Message, ConsoleColor.Red);
                        InitializeApp();
                    }
                    break;
                case '3':
                    try
                    {
                        UpdateEmployee(Employee.getAllInfo());
                    }
                    catch (ApplicationException error)
                    {
                        Alert.showAlert(error.Message, ConsoleColor.Red);
                        InitializeApp();
                    }
                    break;
                case '4':
                    try
                    {
                        DeleteEmployee(Employee.getDocument().Document);
                    }
                    catch (ApplicationException error)
                    {
                        Alert.showAlert(error.Message, ConsoleColor.Red);
                        InitializeApp();
                    }
                    break;
            }
        }



        public static void CreateEmployee(Employee newEmployee)
        {

            try
            {
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
            InitializeApp();
        }

        public static void ReadEmployee(string documment)
        {
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
            InitializeApp();
        }

        public static void UpdateEmployee(Employee updatedEmployee)
        {
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
            InitializeApp();
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
            InitializeApp();
        }
    }
}
