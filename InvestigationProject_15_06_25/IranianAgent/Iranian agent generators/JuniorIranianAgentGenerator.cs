using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25.IranianAgent
{
    internal class JuniorIranianAgentGenerator : GetRandIranianAgent
    {
       

        public static IIranianAgent GenerateAgent()
        {
            IIranianAgent juniorIranianAgent = new JuniorIranianAgent()
            {
                Name = IranianAgentsNames.FullName,
                SensitiveToSensors = SensorsNamesList.GetSensorsNamesList("junior")
            };
            return juniorIranianAgent;
        }



    }
}
