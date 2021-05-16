using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Controller;
using Oreo.Model;
using Oreo.View;

namespace Oreo.Controller
{
    class EmployeeMenu
    {
        public static void LaunchEmployeeMenu()
        {
            int start = 1;
            do
            {
                char opt = '0';
                Banner.ShowBigBanner("Clients");
                opt = char.Parse(Console.ReadLine());
                switch (opt)
                {
                    case '1':
                        try
                        {
                            Banner.ShowBanner("Create Client");
                            EmployeeCtrl.CreateEmployee(Employee.getAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '2':
                        try
                        {
                            Banner.ShowBanner("Search Client");
                            EmployeeCtrl.ReadEmployee(Employee.getDocument().Document);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '3':
                        try
                        {
                            Banner.ShowBanner("Client Database");
                            EmployeeCtrl.ReadAllEmployees();
                            Alert.Confirmation();
                            break;
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '4':
                        try
                        {
                            Banner.ShowBanner("Search Client");
                            EmployeeCtrl.UpdateEmployee(Employee.getAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '5':
                        try
                        {
                            Banner.ShowBanner("Delete Client");
                            EmployeeCtrl.DeleteEmployee(Employee.getDocument().Document);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '6':
                        start = 0;
                        break;
                }
            } while (start == 1);
        }
    }
}
