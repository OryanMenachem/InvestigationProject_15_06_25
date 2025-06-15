using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class SensorsNamesList
    {
        public static List<string> Sensors { get; } = new List<string>();

        public SensorsNamesList()
        {
            Sensors.Add(new Sensor1().SensorName);
            Sensors.Add(new Sensor2().SensorName);
        }


    }
}
