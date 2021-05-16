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
                char opt = '0';
                Console.Clear();
                Welcome();
                Console.Write("\n");
                Alert.showMessage($"====================================================", ConsoleColor.DarkBlue);
                Alert.showMessage($"                     Main Menu", ConsoleColor.DarkMagenta);
                Console.Write("\n");
                Alert.showAlert("(1) Products (2) Clients (3) Shop (4) Print (5) Exit", ConsoleColor.DarkBlue);
                Console.Write("\n");
                Console.Write("\n\tWhat you want to do? ");
                opt = char.Parse(Console.ReadLine());
                switch (opt)
                {
                    case '1':
                        LaunchProductMenu();
                        break;
                    case '2':
                        LaunchEmployeeMenu();
                        break;
                    case '3':
                        LaunchShopMenu();
                        break;
                    case '4':
                        //LaunchPrintMenu();
                        break;
                    case '5':
                        start = 0;
                        Console.Write("\n");
                        Alert.showAlert("Thanks for using this app... bye ! <(*w*<)", ConsoleColor.DarkGreen);
                        break;
                }
            } while (start ==1);

           
        }

        public static void LaunchShopMenu()
        {
            Console.Clear();
            ProductCtrl.ReadAllProducts();
            Console.Write("\n");
            Console.Write("\n\tEnter Product ID: ");
            int opt = char.Parse(Console.ReadLine());

        }

        public static void LaunchProductMenu()
        {
            int start = 1;
            do
            {
                char opt = '0';
                Console.Clear();
                Console.Write("\n");
                Alert.showMessage($"================================================================", ConsoleColor.DarkBlue);
                Alert.showMessage($"                            Products", ConsoleColor.DarkMagenta);
                Console.Write("\n");
                Alert.showAlert("(1) Create (2) Search (3) Catalog (5) Update (5) Delete (6) Exit", ConsoleColor.DarkBlue);
                Console.Write("\n");
                Console.Write("\n\tWhat you want to do? ");
                opt = char.Parse(Console.ReadLine());
                switch (opt)
                {
                    case '1':
                        try
                        {
                            Console.Clear();
                            Console.Write("\n");
                            Alert.showAlert("       Create Product      ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            ProductCtrl.CreateProduct(Product.getAllInfo());
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '2':
                        try
                        {
                            Console.Write("\n");
                            Alert.showAlert("      Search Product     ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            ProductCtrl.ReadProduct(Product.getId().Id);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.Clear();
                            ProductCtrl.ReadAllProducts();
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '4':
                        try
                        {
                            Console.Clear();
                            Console.Write("\n");
                            Alert.showAlert("       Update Product      ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            ProductCtrl.UpdateProduct(Product.getAllInfo());
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '5':
                        try
                        {
                            Console.Clear();
                            Console.Write("\n");
                            Alert.showAlert("       Delete Product      ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            ProductCtrl.DeleteProduct(Product.getId().Id);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '6':
                        start = 0;
                        break;
                }
            } while (start == 1);
        }

        public static void LaunchEmployeeMenu()
        {
            int start = 1;
            do
            {
                char opt = '0';
                Console.Clear();
                Console.Write("\n");
                Alert.showMessage($"================================================================", ConsoleColor.DarkBlue);
                Alert.showMessage($"                             Clients", ConsoleColor.DarkMagenta);
                Console.Write("\n");
                Alert.showAlert("(1) Create (2) Search (3) Catalog (4) Update (5) Delete (6) Exit", ConsoleColor.DarkBlue);
                Console.Write("\n");
                Console.Write("\n\tWhat you want to do? ");
                opt = char.Parse(Console.ReadLine());
                switch (opt)
                {
                    case '1':
                        try
                        {
                            Console.Clear();
                            Console.Write("\n");
                            Alert.showAlert("       Create Client      ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            EmployeeCtrl.CreateEmployee(Employee.getAllInfo());
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '2':
                        try
                        {
                            Console.Clear();
                            Console.Write("\n");
                            Alert.showAlert("       Search Client       ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            EmployeeCtrl.ReadEmployee(Employee.getDocument().Document);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.Clear();
                            EmployeeCtrl.ReadAllEmployees();
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '4':
                        try
                        {
                            Console.Clear();
                            Console.Write("\n");
                            Alert.showAlert("       Update Client       ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            EmployeeCtrl.UpdateEmployee(Employee.getAllInfo());
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '5':
                        try
                        {
                            Console.Clear();
                            Console.Write("\n");
                            Alert.showAlert("       Delete Client      ", ConsoleColor.DarkMagenta);
                            Console.Write("\n");
                            EmployeeCtrl.DeleteEmployee(Employee.getDocument().Document);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Console.Write("\n");
                            Console.Write("\n\tPress enter to continue... ");
                            Console.ReadLine();
                            InitializeApp();
                        }
                        break;
                    case '6':
                        start = 0;
                        break;
                }
            } while (start == 1);
        }

        public static void Welcome()
        {
            Alert.showAlert("Welcome to Cookie Factory! =)", ConsoleColor.DarkBlue);
            Alert.showMessage($"====================", ConsoleColor.DarkMagenta);
            Alert.showMessage($"                       _/0\\/ \\_", ConsoleColor.DarkCyan);
            Alert.showMessage($"              .-.   .-` \\_/\\0/ '-.", ConsoleColor.DarkCyan);
            Alert.showMessage($"             /:::\\ / ,_________,  \\", ConsoleColor.DarkCyan);
            Alert.showMessage($"            /\\:::/ \\  '. (:::/  `'-;", ConsoleColor.DarkCyan);
            Alert.showMessage($"            \\ `-'`\\ '._ `\"'\"'\\__    \\", ConsoleColor.DarkCyan);
            Alert.showMessage($"             `'-.  \\   `)-=-=(  `,   |", ConsoleColor.DarkCyan);
            Alert.showMessage($"                 \\  `-\"`      `\"-`   /         Satan", ConsoleColor.DarkCyan);
            Alert.showMessage($"====================================================", ConsoleColor.DarkMagenta);
        }
    }
}
