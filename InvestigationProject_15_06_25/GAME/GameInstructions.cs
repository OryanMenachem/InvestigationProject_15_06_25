using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class GameInstructions
    {
        public static void ShowInstructions()
        {
            ConsoleDesign.CyanColor("Instructions:\n");
            Console.WriteLine("- You will now interrogate an Iranian agent of a random rank.\n" +
                              "- Your mission is to uncover which sensors are needed to expose him.\n" +
                              "- Note that the higher the rank of the agent, the more sensors are needed to expose him.\n");
            ConsoleDesign.CyanColor("Good luck!\n") ;

            Console.WriteLine("To return to the menu, press enter...\n");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
