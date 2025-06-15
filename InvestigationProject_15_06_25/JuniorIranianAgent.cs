using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class JuniorIranianAgent : IIranianAgent
    {
        public string Name { get; set; }

        public string Rank { get; } = "Junior";
        public List<ISensors> SensorsList { get; set; } 

        public JuniorIranianAgent(string name, List<ISensors> sensorsList)
        {
            Name = name;
            SensorsList = sensorsList;
        }



  

        
        
    }
}
