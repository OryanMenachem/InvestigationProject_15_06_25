using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationProject_15_06_25.IranianAgent;
using InvestigationProject_15_06_25.IranianAgent.Iranian_agent_generators;

namespace InvestigationProject_15_06_25
{
    internal class GetRandIranianAgent 
    {
        /// <summary>
        /// Returns an Iranian agent at a random rank
        /// </summary>
        /// <returns></returns>
        public IIranianAgent GetIranianAgent()
        {

            Random random = new Random();

            List<string> iranianAgentsRanks = new List<string>() {"junior", "Squad Leader" }; // List of ranks of all established Iranian agents

            string randomRank = iranianAgentsRanks[random.Next(0, 2)]; // לשנות ל -2 בהתאם

            IIranianAgent iranianAgent = null;

            switch (randomRank) 
            {
                case "junior":
                    iranianAgent = new JuniorIranianAgentGenerator().GenerateAgent();
                 break;

                case "Squad Leader":
                    iranianAgent = new SquadLeaderAgentGenerator().GenerateAgent();
                    break;

                default:
                    Console.WriteLine();
                    break;

            }
            return iranianAgent;
        }

    }
}
