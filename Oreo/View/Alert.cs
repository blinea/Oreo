using System;
using System.Collections.Generic;
using System.Text;

namespace Oreo.View
{
    class Alert
    {
        public static void showAlert(string Message, ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
            string line = "\t";
            for (int i = 0; i < Message.Length; i++)
            {
                line += "=";
            }
            System.Console.Write(line);
            System.Console.WriteLine($"\n\t{Message}");
            System.Console.Write(line);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void showMessage(string Message, ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
            System.Console.WriteLine($"\t{Message}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Confirmation()
        {
            Console.Write("\n");
            Console.Write("\n\tPress enter to continue... ");
            Console.ReadLine();
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

        public static void Bye()
        {
            Console.Write("\n");
            Alert.showAlert("Thanks for using this app... bye ! <(*w*<)", ConsoleColor.DarkGreen);
            Console.Write("\n");
        }
    }
}
