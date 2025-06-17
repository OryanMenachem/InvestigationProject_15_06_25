using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationProject_15_06_25.IranianAgent;

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

            List<string> iranianAgentsRanks = new List<string>() {"junior"}; // List of ranks of all established Iranian agents

            string randomRank = iranianAgentsRanks[random.Next(0, 1)]; 

            IIranianAgent iranianAgent = null;

            switch (randomRank) 
            {
                case "junior":
                    iranianAgent = new JuniorIranianAgentGenerator().GenerateAgent();
                 break;

                default:
                    Console.WriteLine();
                    break;

            }
            return iranianAgent;
        }

    }
}
