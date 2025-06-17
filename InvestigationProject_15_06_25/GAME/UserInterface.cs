using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class UserInterface
    {
        private static bool flag = true;
    
        public static void Run()
        {
         
            Console.WriteLine("Welcome to the investigation game, \n" +
                                "A game where you will interrogate agents and expose Iranian agents.\n");
            while (flag)
            {
                ShowMenu();

                Console.Write("\n> ");
                string cohice = Console.ReadLine().Trim();

                HandleChoice(cohice);

            }

            
        }

        private static void ShowMenu()
        {
            
                ConsoleDesign.CyanColor("Please select one of the following options:\n");

                ConsoleDesign.CyanColor("******* MENU **********  ");
                ConsoleDesign.CyanColor("\n* 1. new game.        *");
                ConsoleDesign.CyanColor("\n* 2. instructions     *");
                ConsoleDesign.CyanColor("\n* 3. exit.            *");
                ConsoleDesign.CyanColor("\n***********************");

            
            
        }

        private static void HandleChoice(string choice)
        {
            Console.Clear();

            switch (choice)
            {
                case "1":
                    NewGame();
                    break;
                case "2":
                    Instructions();
                    break;
                case "3":
                    Exit();
                    break;
                default:
                    ConsoleDesign.ErrorColor("No valid choice was made!\n");
                    break;

            }
        }

        private static void NewGame()
        {
            InvestigationManager investigationManager = new InvestigationManager();

        }

        private static void Instructions()
        {
            GameInstructions.ShowInstructions();

        }

        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine();
            ConsoleDesign.CyanColor("Good bye!");
            flag = false;

        }


    }
}
