using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Model;
using Oreo.Controller;

namespace Oreo.View
{
    class App
    {
        public static void InitializeApp()
        {
           LaunchMenu();
        }

        public static void LaunchMenu()
        {
            int start = 1;
            do
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
                            EmployeeCtrl.CreateEmployee(Employee.getAllInfo());
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
                            EmployeeCtrl.ReadEmployee(Employee.getDocument().Document);
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
                            EmployeeCtrl.UpdateEmployee(Employee.getAllInfo());
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
                            EmployeeCtrl.DeleteEmployee(Employee.getDocument().Document);
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            InitializeApp();
                        }
                        break;
                    case '5':
                        start = 0;
                        break;
                }
            } while (start == 1);
        }
    }
}
