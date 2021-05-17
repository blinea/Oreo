using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Controller;
using Oreo.Model;
using Oreo.View;

namespace Oreo.View
{
    class EmployeeMenu
    {
        public static void LaunchEmployeeMenu()
        {
            int start = 1;
            do
            {
                char option = '0';
                Banner.ShowBigBanner("Clients");
                try
                {
                    option = char.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Alert.ShowAlert("Please type a valid Option", ConsoleColor.Red);
                    Alert.Confirmation();
                }
                switch (option)
                {
                    case '1':
                        try
                        {
                            Banner.ShowBanner("Create Client");
                            EmployeeCtrl.CreateEmployee(Employee.GetAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '2':
                        try
                        {
                            Banner.ShowBanner("Search Client");
                            EmployeeCtrl.ReadEmployee(Employee.GetDocument().Document);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
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
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '4':
                        try
                        {
                            Banner.ShowBanner("Search Client");
                            EmployeeCtrl.UpdateEmployee(Employee.GetAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '5':
                        try
                        {
                            Banner.ShowBanner("Delete Client");
                            EmployeeCtrl.DeleteEmployee(Employee.GetDocument().Document);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
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
