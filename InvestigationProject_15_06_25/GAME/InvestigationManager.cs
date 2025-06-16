using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class InvestigationManager
    {
        static bool flag = true;
        static bool end = true;
        static IIranianAgent iranianAgent;
        public InvestigationManager()
        {

            iranianAgent = IranianAgentGenerator.GetIranianAgent();

            Console.WriteLine();
            Console.Write("The agent to be interrogated is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"* {iranianAgent.Name} * ");
            Console.ResetColor();
            Console.Write("an Iranian agent of the rank of ");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"* {iranianAgent.Rank} *\n");
            Console.ResetColor();

            while (end)
            {
                flag = true;

                Start(iranianAgent);

                while (!flag)
                {
                    Start(iranianAgent);
                }

                InputSensor();
                Result(iranianAgent);
            }
        }








        private static void Start(IIranianAgent iranianAgent)
        {

            Console.WriteLine($"\nPlease attach one of the following sensors:\n\n" +
                              $"1. sensor1\n" +
                              $"2. sensor2\n" +
                              $"3. sensor3\n" +
                              $"4. sensor4\n");
        }

        private static void InputSensor()
        {
            Console.Write("\n> ");

            string sensor = Console.ReadLine().Trim();

            Console.Clear();
            Console.WriteLine();

            switch (sensor)
            {
                case "sensor1":
                    ActivateSensor1(iranianAgent);
                    break;
                case "sensor2":
                    ActivateSensor2(iranianAgent);
                    break;
                //case "sensor3":
                //    ActivateSensor3(iranianAgent);
                //    break;
                //case "sensor4":
                //    ActivateSensor4(iranianAgent);
                //    break;
                default:
                    TextColor.ErrorColor($"The sensor '{sensor}', does not exist!\n");
                    flag = false;
                    break;

            }

        }

        private static void ActivateSensor1(IIranianAgent iranianAgent)
        {
            Sensor1 sensor1 = new Sensor1();

            sensor1.Activate(iranianAgent);
            
            flag = false;
           
        }
          
            
        

        private static void ActivateSensor2(IIranianAgent iranianAgent)
        {
            Sensor2 sensor2 = new Sensor2();

            sensor2.Activate(iranianAgent);
          
            flag = false;
            
        }
        




        private static void Result(IIranianAgent iranianAgent)
        {
            if (iranianAgent.SensorsNamesList.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Congratulations! you exposed the agent ");
                Console.ResetColor();
                Console.WriteLine($"* {iranianAgent.Name} * \n");

                Console.WriteLine("To return to the menu, press enter...");

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine();

                end = false;
            }
            else
            {
                Console.WriteLine($"{iranianAgent.SensorsNamesList.Count()} " +
                                 "- More sensors left to reveal the target.\n");
           
                flag = false;
            }
       

        }





    }
}
