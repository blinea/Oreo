using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Model;
using Oreo.Controller;
using Oreo.View;

namespace Oreo.View
{
    class App
    {
        public static void InitializeApp()
        {
            int start = 1;
            do
            {               
                char option = '0';
                Console.Clear();
                Alert.Welcome();
                Banner.ShowMainMenu();              
                try
                {
                    option = char.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Alert.ShowAlert("Invalid Option", ConsoleColor.Red);
                    Alert.Confirmation();
                }
                switch (option)
                {
                    case '1':
                        ProductMenu.LaunchProductMenu();
                        break;
                    case '2':
                        EmployeeMenu.LaunchEmployeeMenu();
                        break;
                    case '3':
                        Login();
                        break;
                    case '4':
                        LaunchPrintMenu();
                        break;
                    case '5':
                        start = 0;
                        Alert.Bye();
                        break;
                }
            } while (start ==1);      
        }

        public static void Login()
        {

            string userId = Employee.GetDocument().Document;

            if (EmployeeCtrl.SearchEmployeeDocument(userId))
            {
                Shop.LaunchShopMenu(userId);
            }
            else
            {
                Alert.ShowAlert("User doesn't exist on database", ConsoleColor.DarkRed);
                Alert.Confirmation();
            }
                         
        }

        public static void LaunchPrintMenu()
        {
            Console.Clear();
            Banner.ShowBanner("    Print    ");
            Alert.ShowAlert("  Print Mode Enabled  ", ConsoleColor.Red);
            Alert.Confirmation();
        }

    }
}
