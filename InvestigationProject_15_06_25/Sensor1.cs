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

        public string Activate()
        {
            return SensorName;
        }
    }
}
