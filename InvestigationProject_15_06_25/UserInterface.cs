using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class UserInterface
    {
        private bool flag = true;
        public void opening()
        {
            Console.WriteLine("Welcome to the investigation game, \n" +
                "A game where you will interrogate agents and expose Iranian agents/n");


        }

        public void ShowMenu()
        {
            while (flag)
            {

                Console.WriteLine("Please select one of the following options:/n");

                Console.WriteLine("************ MENU ************");
                Console.WriteLine("*                            *");
                Console.WriteLine("* 1. New game.               *");
                Console.WriteLine("*                            *");
                Console.WriteLine("* 2. Exit.                   *");
                Console.WriteLine("******************************");

            }
            
        }

        public void MainHandleChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    HandleChoice2();
                    break;
                case "2":
                    HandleChoice2();
                    break;
                default:
                    Console.WriteLine("No valid choice was made!");
                    break;

            }
        }

        private void HandleChoice1()
        {

        }

        private void HandleChoice2()
        {
            Console.Clear();
            flag = false;
            Console.WriteLine("Good bye!");
        }


    }
}
