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
        public List<string> SensorsNamesList { get; set; } 

        public JuniorIranianAgent(string name, List<string> sensorsList)
        {
            Name = name;
            SensorsNamesList = sensorsList;
        }



  

        
        
    }
}
