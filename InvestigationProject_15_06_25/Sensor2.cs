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
            TextColor.SuccessfullColor($"{SensorName} action...");

            if (iranianAgent.SensorsNamesList.Contains(SensorName)) { return true; }
            return false;


        }

    }
}
