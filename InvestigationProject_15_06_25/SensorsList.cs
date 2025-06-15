using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class SensorsList
    {
        public static List<ISensors> Sensors { get; } = new List<ISensors>();

        public SensorsList()
        {
            Sensors.Add(new Sensor1());
            Sensors.Add(new Sensor2());
        }


    }
}
