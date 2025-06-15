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
                                "A game where you will interrogate agents and expose Iranian agents\n");
            while (flag)
            {
                ShowMenu();

                string cohice = Console.ReadLine().Trim();

                MainHandleChoice(cohice);

            }

            
        }

        private static void ShowMenu()
        {
            
                TextColor.CyanColor("Please select one of the following options:\n");

                TextColor.CyanColor("******** MENU *********");
                TextColor.CyanColor("* 1. new game.        *");
                TextColor.CyanColor("* 2. exit.            *");
                TextColor.CyanColor("***********************");

            
            
        }

        private static void MainHandleChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    HandleChoice1();
                    break;
                case "2":
                    HandleChoice2();
                    break;
                default:
                    TextColor.ErrorColor("No valid choice was made!");
                    break;

            }
        }

        private static void HandleChoice1()
        {
            GameInstructions.ShowInstructions();
            Console.ReadLine();
            InvestigationManager investigationManager = new InvestigationManager();

        }

        private static void HandleChoice2()
        {
            Console.Clear();
            TextColor.SuccessfullColor("\nGood bye!");
            flag = false;

        }


    }
}
