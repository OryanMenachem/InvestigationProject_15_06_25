using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationProject_15_06_25.IranianAgent;

namespace InvestigationProject_15_06_25
{
    internal class InvestigationManager
    {
        private bool flag;
        private bool end;
        private IIranianAgent iranianAgent;

        public InvestigationManager()
        {
            iranianAgent = new GetRandIranianAgent().GetIranianAgent();
           
            flag = true;
            
            end = true;
        }

        public void GameManager() 
        { 
            DisplayAgentNameAndRank();

            while (end)
            {
                flag = true;

                DisplaySensors();

                while (!flag)
                {
                    DisplaySensors();
                }

                InputSensor();
                Result();
            }
       

        }

        private void DisplayAgentNameAndRank()
        {

            Console.Write("The agent to be interrogated is ");

            ConsoleDesign.RedColor($"* {iranianAgent.Name} * ", false);

            Console.Write("an Iranian agent of the rank of ");

            ConsoleDesign.RedColor($"* {iranianAgent.Rank} *\n");

        }

        private void DisplaySensors()
        {

            Console.WriteLine($"\nPlease attach one of the following sensors:\n\n" +
                              $"1. sensor1\n" +
                              $"2. sensor2\n" +
                              $"3. pulse sensor\n");
                          
        }

        private void InputSensor()
        {


            string sensor = ConsoleDesign.Input();

            switch (sensor)
            {
                case "sensor1":
                    ActivateSensor1();
                    break;
                case "sensor2":
                    ActivateSensor2();
                    break;
                case "pulse sensor":
                    ActivatePulseSensor();
                    break;
                default:
                    ConsoleDesign.ErrorColor($"The sensor '{sensor}', does not exist!\n");
                    flag = false;
                    break;

            }

        }
           



        private void ActivateSensor1()
        {
            Sensor1 sensor1 = new Sensor1();

            iranianAgent.AttachedSensors.Add(sensor1);
      

            sensor1.Activate(iranianAgent);
            
            flag = false;
           
        }

        private void ActivateSensor2()
        {
            Sensor2 sensor2 = new Sensor2();

            iranianAgent.AttachedSensors.Add(sensor2);

            sensor2.Activate(iranianAgent);
          
            flag = false;
            
        }

        private void ActivatePulseSensor()
        {
            PulseSensor pulseSensor = new PulseSensor();


            iranianAgent.AttachedSensors.Add(pulseSensor);
            iranianAgent.Count += 1;

            pulseSensor.Activate(iranianAgent);

            flag = false;

        }

        private void Result()
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

        private void DisplaySuccessMessage()
        {
            ConsoleDesign.SuccessfullColor("Congratulations! you exposed the agent - ", false);

            ConsoleDesign.RedColor($" {iranianAgent.Name}.\n");

            Console.Write("To return to the menu, press enter... ");

            Console.ReadLine();
            Console.Clear();
  

        }


          
            
        

        










    }
}
