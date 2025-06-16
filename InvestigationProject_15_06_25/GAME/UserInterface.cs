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
            
                TextColor.CyanColor("Please select one of the following options:\n");

                TextColor.CyanColor("******** MENU *********");
                TextColor.CyanColor("\n* 1. new game.        *");
                TextColor.CyanColor("\n* 2. instructions     *");
                TextColor.CyanColor("\n* 3. exit.            *");
                TextColor.CyanColor("\n***********************");

            
            
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
                    TextColor.ErrorColor("No valid choice was made!\n");
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
            TextColor.CyanColor("Good bye!");
            flag = false;

        }


    }
}
