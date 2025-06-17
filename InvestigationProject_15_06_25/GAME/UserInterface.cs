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
            DisplayOpeningMessage();

            while (flag)
            {

                DisplayMenu();

                string cohice = ConsoleDesign.Input();

                HandleChoice(cohice);

            }

            
        }

        private static void DisplayOpeningMessage()
        {

            Console.WriteLine("Welcome to the investigation game, \n" +
                                "A game where you will interrogate agents and expose Iranian agents.\n");

        }

        private static void DisplayMenu()
        {
            
                ConsoleDesign.CyanColor("Please select one of the following options:\n");

                ConsoleDesign.CyanColor("\n******* MENU **********");
                ConsoleDesign.CyanColor("\n* 1. new game.        *");
                ConsoleDesign.CyanColor("\n* 2. instructions     *");
                ConsoleDesign.CyanColor("\n* 3. exit.            *");
                ConsoleDesign.CyanColor("\n***********************");

            
            
        }

        private static void HandleChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    NewGame();
                    break;
                case "2":
                    DisplayInstructions();
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
            investigationManager.GameManager();

        }

        /// <summary>
        /// Prints game instructions to the console
        /// </summary>
        private static void DisplayInstructions()
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
