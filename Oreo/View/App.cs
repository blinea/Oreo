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
                Console.Write("\n");
                Alert.showMessage($"====================================================", ConsoleColor.DarkYellow);
                Alert.showMessage($"                     Main Menu", ConsoleColor.DarkMagenta);
                Console.Write("\n");
                Alert.showAlert("(1) Products (2) Clients (3) Shop (4) Print (5) Exit", ConsoleColor.DarkYellow);
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
                        Alert.showAlert("Thanks for using this app <(*w*<)", ConsoleColor.DarkGreen);
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
                Console.Write("\n");
                Alert.showMessage($"==================================================", ConsoleColor.DarkYellow);
                Alert.showMessage($"                   Products", ConsoleColor.DarkMagenta);
                Console.Write("\n");
                Alert.showAlert("(1) Create (2) Read (3) Update (4) Delete (5) Exit", ConsoleColor.DarkYellow);
                Console.Write("\n");
                Console.Write("\n\tWhat you want to do? ");
                opt = char.Parse(Console.ReadLine());
                switch (opt)
                {
                    case '1':
                        try
                        {
                            ProductCtrl.CreateProduct(Product.getAllInfo());
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
                            ProductCtrl.ReadProduct(Product.getId().Id);
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
                            ProductCtrl.UpdateProduct(Product.getAllInfo());
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
                            ProductCtrl.DeleteProduct(Product.getId().Id);
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

        public static void LaunchEmployeeMenu()
        {
            int start = 1;
            do
            {
                char opt = '0';
                Console.Write("\n");
                Alert.showMessage($"==================================================", ConsoleColor.DarkYellow);
                Alert.showMessage($"                   Clients", ConsoleColor.DarkMagenta);
                Console.Write("\n");
                Alert.showAlert("(1) Create (2) Read (3) Update (4) Delete (5) Exit", ConsoleColor.DarkYellow);
                Console.Write("\n");
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

        public static void Welcome()
        {
            Alert.showAlert("Welcome to Cookie Factory! =)", ConsoleColor.DarkRed);
            Alert.showMessage($"====================", ConsoleColor.DarkMagenta);
            Alert.showMessage($"                       _/0\\/ \\_", ConsoleColor.DarkBlue);
            Alert.showMessage($"              .-.   .-` \\_/\\0/ '-.", ConsoleColor.DarkBlue);
            Alert.showMessage($"             /:::\\ / ,_________,  \\", ConsoleColor.DarkBlue);
            Alert.showMessage($"            /\\:::/ \\  '. (:::/  `'-;", ConsoleColor.DarkBlue);
            Alert.showMessage($"            \\ `-'`\\ '._ `\"'\"'\\__    \\", ConsoleColor.DarkBlue);
            Alert.showMessage($"             `'-.  \\   `)-=-=(  `,   |", ConsoleColor.DarkBlue);
            Alert.showMessage($"                 \\  `-\"`      `\"-`   /         Satan", ConsoleColor.DarkBlue);
            Alert.showMessage($"====================================================", ConsoleColor.DarkMagenta);
        }
    }
}
