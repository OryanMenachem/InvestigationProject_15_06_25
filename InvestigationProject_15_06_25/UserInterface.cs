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
            
                Console.WriteLine("Please select one of the following options:\n");

                Console.WriteLine("******** MENU *********");
                Console.WriteLine("*                     *");
                Console.WriteLine("* 1. new game.        *");
                Console.WriteLine("* 2. exit.            *");
                Console.WriteLine("*                     *");
                Console.WriteLine("***********************");

            
            
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
                    Console.WriteLine("No valid choice was made!");
                    break;

            }
        }

        private static void HandleChoice1()
        {
            GameInstructions.ShowInstructions();
            Console.ReadLine();

        }

        private static void HandleChoice2()
        {
            Console.Clear();
            Console.WriteLine("\nGood bye!");
            flag = false;

        }


    }
}
