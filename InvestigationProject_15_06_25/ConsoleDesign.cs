using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class ConsoleDesign
    {
        public static string Input()
        {
            Console.Write(">");

            string input = Console.ReadLine().Trim();

            Console.Clear();
            Console.WriteLine();

            return input;
        }

        public static void ErrorColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{text}");
            Console.ResetColor();

        }

        public static void SuccessfullColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{text}");
            Console.ResetColor();



        }

        public static void CyanColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{text} ");
            Console.ResetColor();

        }

        public static void RedColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{text} ");
            Console.ResetColor();

        }

    }
}
