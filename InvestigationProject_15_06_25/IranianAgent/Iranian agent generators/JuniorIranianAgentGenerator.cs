using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25.IranianAgent
{
    internal class JuniorIranianAgentGenerator : GetRandIranianAgent
    {
       

        public IIranianAgent GenerateAgent()
        {
            IIranianAgent juniorIranianAgent = new JuniorIranianAgent()
            {
                Name = new IranianAgentsNames().fullName(),
                SensitiveToSensors = SensorsNamesList.GetSensorsNamesList("junior")
            };
            return juniorIranianAgent;
        }



    }
}
