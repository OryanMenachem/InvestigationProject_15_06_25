using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25.IranianAgent
{
    internal class PulseSensor : ISensors
    {
        public string SensorName { get; } = "pulse sensor";

        private static int remainingUses = 3; 
        public void Activate(IIranianAgent iranianAgent)
        {
            if (remainingUses > 0)
            {
                ConsoleDesign.SuccessfullColor($"{SensorName} action...\n");

                remainingUses--;

                if (iranianAgent.SensitiveToSensors.Contains(SensorName))
                {
                    iranianAgent.SensitiveToSensors.Remove(SensorName);


                }
                else
                {
                    Console.Write($"\nThis agent is not affected by the sensor - ");
                    ConsoleDesign.CyanColor($"{SensorName}.\n");
                }
            }
            else
            {
                Console.WriteLine($"{SensorName} is broken\n");
            }
         

        }
    }
}
