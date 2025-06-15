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

            Console.WriteLine($"The agent to be interrogated is * {iranianAgent.Name} * " +
                                $"an Iranian agent of the rank of {iranianAgent.Rank}.\n");
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
            string sensor = Console.ReadLine().Trim();

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
                    TextColor.ErrorColor($"The sensor '{sensor}', does not exist!");
                    flag = false;
                    break;

            }

        }

        private static void ActivateSensor1(IIranianAgent iranianAgent)
        {
            Sensor1 sensor1 = new Sensor1();

            if (sensor1.Activate(iranianAgent)) { iranianAgent.SensorsNamesList.Remove("sensor1"); }
            else
            {
                Console.WriteLine($"\nThis agent is not affected by the sensor - {sensor1.SensorName}.\n");
            }
            flag = false;
        
        }

        private static void ActivateSensor2(IIranianAgent iranianAgent)
        {
            Sensor2 sensor2 = new Sensor2();

            if (sensor2.Activate(iranianAgent)) { iranianAgent.SensorsNamesList.Remove("sensor2"); }
            else
            {
                Console.WriteLine($"\nThis agent is not affected by the sensor - {sensor2.SensorName}.\n");
            }
            flag = false;
            
        }
        




        private static void Result(IIranianAgent iranianAgent)
        {
            if (iranianAgent.SensorsNamesList.Count() == 0)
            {
                TextColor.SuccessfullColor($"Congratulations! you exposed the agent * {iranianAgent.Name} * \n");
                Console.WriteLine("To return to the menu, press enter...");
                Console.ReadLine();
                Console.Clear();
                end = false;
            }
            else
            {
                Console.WriteLine($"{iranianAgent.SensorsNamesList.Count()} More sensors left to reveal the target.\n");
                flag = false;
            }
       

        }





    }
}
