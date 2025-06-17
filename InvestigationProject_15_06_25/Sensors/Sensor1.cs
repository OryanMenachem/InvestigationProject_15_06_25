using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class Sensor1 : ISensors
    {
        public string SensorName { get; } = "sensor1";

        public void Activate(IIranianAgent iranianAgent)
        {
            ConsoleDesign.SuccessfullColor($"{SensorName} action...\n");

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
         
    }
}
