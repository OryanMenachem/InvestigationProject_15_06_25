using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class Sensor2 : ISensors
    {
        public string SensorName { get; } = "sensor2";

        public bool Activate(IIranianAgent iranianAgent)
        {
            ConsoleDesign.SuccessfullColor($"{SensorName} action...\n");

            if (iranianAgent.SensitiveToSensors.Contains(SensorName))
            {
                iranianAgent.SensitiveToSensors.Remove(SensorName);

                return true;
            }

            Console.Write($"\nThis agent is not affected by the sensor - ");
            ConsoleDesign.CyanColor($"{SensorName}.\n");

            return false;


        }

    }
}
