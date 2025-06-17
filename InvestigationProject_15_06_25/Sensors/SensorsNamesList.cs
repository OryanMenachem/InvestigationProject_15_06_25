using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationProject_15_06_25.IranianAgent;

namespace InvestigationProject_15_06_25
{
    internal class SensorsNamesList
    {
        private Random random = new Random();
        
        private readonly List<string> Sensors = new List<string> { new Sensor1().SensorName, new Sensor2().SensorName, new PulseSensor().SensorName};



        public List<string> GetSensorsNamesList(string rankAgent)
        {
            List<string> sensorsNameslist = new List<string>();

            switch (rankAgent)
            {
                case "junior":
                    sensorsNameslist.Add(Sensors[random.Next(0, 2)]); 
                    sensorsNameslist.Add(Sensors[random.Next(0, 2)]); 
                        break;

                case "Squad Leader":
                    sensorsNameslist.Add(Sensors[random.Next(0, 4)]); 
                    sensorsNameslist.Add(Sensors[random.Next(0, 4)]); 
                    sensorsNameslist.Add(Sensors[random.Next(0, 4)]); 
                    sensorsNameslist.Add(Sensors[random.Next(0, 4)]); 
                    break;

                    default:
                    Console.WriteLine();
                    break;

            }
            return sensorsNameslist;
        }




    }
}
