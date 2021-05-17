using System;
using System.Collections.Generic;
using System.Text;

namespace Oreo.View
{
    class Alert
    {
        public static void ShowAlert(string Message, ConsoleColor Color)
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

        public static void ShowMessage(string Message, ConsoleColor Color)
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
            Alert.ShowAlert("Welcome to Cookie Factory! =)", ConsoleColor.DarkBlue);
            Alert.ShowMessage($"====================", ConsoleColor.DarkMagenta);
            Alert.ShowMessage($"                       _/0\\/ \\_", ConsoleColor.DarkCyan);
            Alert.ShowMessage($"              .-.   .-` \\_/\\0/ '-.", ConsoleColor.DarkCyan);
            Alert.ShowMessage($"             /:::\\ / ,_________,  \\", ConsoleColor.DarkCyan);
            Alert.ShowMessage($"            /\\:::/ \\  '. (:::/  `'-;", ConsoleColor.DarkCyan);
            Alert.ShowMessage($"            \\ `-'`\\ '._ `\"'\"'\\__    \\", ConsoleColor.DarkCyan);
            Alert.ShowMessage($"             `'-.  \\   `)-=-=(  `,   |", ConsoleColor.DarkCyan);
            Alert.ShowMessage($"                 \\  `-\"`      `\"-`   /         Satan", ConsoleColor.DarkCyan);
            Alert.ShowMessage($"====================================================", ConsoleColor.DarkMagenta);
        }

        public static void Bye()
        {
            Console.Write("\n");
            Alert.ShowAlert("     Thanks for using this app... bye ! <(*w*<)     ", ConsoleColor.DarkGreen);
            Console.Write("\n");
        }
    }
}
