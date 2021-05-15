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
    }
}
