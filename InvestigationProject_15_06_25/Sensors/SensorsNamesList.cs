using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class SensorsNamesList
    {
        static Random random = new Random();
        
        private static List<string> Sensors = new List<string> { new Sensor1().SensorName, new Sensor2().SensorName };



        public static List<string> GetSensorsNamesList(string rankAgent)
        {
            List<string> sensorsNameslist = new List<string>();

            switch (rankAgent)
            {
                case "junior":
                    sensorsNameslist.Add(Sensors[random.Next(0, 2)]);
                    sensorsNameslist.Add(Sensors[random.Next(0, 2)]);
                        break;

            }
            return sensorsNameslist;
        }




    }
}
