using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationProject_15_06_25.IranianAgent.Agent;

namespace InvestigationProject_15_06_25.IranianAgent.Iranian_agent_generators
{
    internal class SquadLeaderAgentGenerator : GetRandIranianAgent
    {
     
            public IIranianAgent GenerateAgent()
            {
                IIranianAgent squadLeaderIranianAgent = new SquadLeaderIranianAgent()
                {
                    Name = new IranianAgentsNames().FullName(),
                    SensitiveToSensors = new SensorsNamesList().GetSensorsNamesList("Squad Leader")
                };
                return squadLeaderIranianAgent;
            }





        
    }
}
