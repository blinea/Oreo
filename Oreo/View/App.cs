using System;

namespace Oreo.View
{
    class App
    {
        enum Options
        {
            Default = 0,
            Products = 1,
            Employees = 2,
            Shop = 3,
            Print = 4,
            Exit = 5
        }

        public static void InitializeApp()
        {
            bool start = true;
            do
            {               
                int option = (int)Options.Default;
                Console.Clear();
                Alert.Welcome();
                Banner.ShowMainMenu();              
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Alert.ShowAlert("Invalid Option", ConsoleColor.Red);
                    Alert.Confirmation();
                }
                switch (option)
                {
                    case (int)Options.Products:
                        ProductMenu.LaunchProductMenu();
                        break;
                    case (int)Options.Employees:
                        EmployeeMenu.LaunchEmployeeMenu();
                        break;
                    case (int)Options.Shop:
                        UtilityMenu.Login();
                        break;
                    case (int)Options.Print:
                        UtilityMenu.LaunchPrintMenu();
                        break;
                    case (int)Options.Exit:
                        start = false;
                        Alert.Bye();
                        break;
                }
            } while (start);      
        }
    }
}
