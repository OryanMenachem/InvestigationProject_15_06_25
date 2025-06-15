using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class TextColor
    {
        public static void ErrorColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{text}\n");
            Console.ResetColor();
        }

        public static void SuccessfullColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{text}\n");
            Console.ResetColor();

           
        }

        public static void CyanColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{text}\n");
            Console.ResetColor();
        }



    }
}
