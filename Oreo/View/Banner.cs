using System;
using System.Collections.Generic;
using System.Text;

namespace Oreo.View
{
    class Banner
    {
        public static void ShowBanner(string title)
        {
            Console.Clear();
            Console.Write("\n");
            Alert.showAlert("      "+title+"      ", ConsoleColor.DarkMagenta);
            Console.Write("\n");
        }

        public static void ShowBigBanner(string title)
        {
            Console.Clear();
            Console.Write("\n");
            Alert.showMessage($"================================================================", ConsoleColor.DarkBlue);
            Alert.showMessage($"                            "+title, ConsoleColor.DarkMagenta);
            Console.Write("\n");
            Alert.showAlert("(1) Create (2) Search (3) Catalog (5) Update (5) Delete (6) Home", ConsoleColor.DarkBlue);
            Console.Write("\n");
            Console.Write("\n\tWhat you want to do? ");
        }

        public static void ShowMainMenu()
        {
            Console.Write("\n");
            Alert.showMessage($"====================================================", ConsoleColor.DarkBlue);
            Alert.showMessage($"                     Main Menu", ConsoleColor.DarkMagenta);
            Console.Write("\n");
            Alert.showAlert("(1) Products (2) Clients (3) Shop (4) Print (5) Exit", ConsoleColor.DarkBlue);
            Console.Write("\n");
            Console.Write("\n\tWhat you want to do? ");
        }
    }
}
