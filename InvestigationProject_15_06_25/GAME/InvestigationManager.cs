using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class InvestigationManager
    {
        static bool flag;
        static bool end;
        static IIranianAgent iranianAgent;
        public InvestigationManager()
        {

            iranianAgent = GetRandIranianAgent.GetIranianAgent();
            flag = true;
            end = true;
        }

        public void Manager() 
        { 
            DisplayAgentNameAndRank();

            while (end)
            {
                flag = true;

                DisplaySensors(iranianAgent);

                while (!flag)
                {
                    DisplaySensors(iranianAgent);
                }

                InputSensor();
                Result(iranianAgent);
            }

        }


        private static void DisplayAgentNameAndRank()
        {

            Console.Write("The agent to be interrogated is ");

            ConsoleDesign.RedColor($"* {iranianAgent.Name} * ", false);

            Console.Write("an Iranian agent of the rank of ");

            ConsoleDesign.RedColor($"* {iranianAgent.Rank} *\n");

        }







        private static void DisplaySensors(IIranianAgent iranianAgent)
        {

            Console.WriteLine($"\nPlease attach one of the following sensors:\n" +
                              $"1. sensor1\n" +
                              $"2. sensor2\n");
                          
        }

        private static void InputSensor()
        {


            string sensor = ConsoleDesign.Input();

           

            switch (sensor)
            {
                case "sensor1":
                    ActivateSensor1(iranianAgent);
                    break;
                case "sensor2":
                    ActivateSensor2(iranianAgent);
                    break;
                default:
                    ConsoleDesign.ErrorColor($"The sensor '{sensor}', does not exist!\n");
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
            if (iranianAgent.SensitiveToSensors.Count() == 0)
            {
                
                DisplaySuccessMessage();

                end = false;

            }
            else
            {
                Console.WriteLine($"{iranianAgent.SensitiveToSensors.Count()} " +
                                 "- More sensors left to reveal the target.\n");
           
                flag = false;
            }

       

        }

        private static void DisplaySuccessMessage()
        {
            ConsoleDesign.SuccessfullColor("Congratulations! you exposed the agent - ", false);

            ConsoleDesign.RedColor($" {iranianAgent.Name}.\n");

            Console.Write("To return to the menu, press enter... ");

            Console.ReadLine();
            Console.Clear();
  

        }





    }
}
