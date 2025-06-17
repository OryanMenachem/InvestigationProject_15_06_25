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
       /// מחזיר סוכן איראני בדרגה אקראית
       /// </summary>
       /// <returns></returns>
        public static IIranianAgent GetIranianAgent()
        {

            Random random = new Random();

            List<string> iranianAgentsRanks = new List<string>() {"junior"}; // רשימת דרגות של כל הסוכנם האיראניים הקימים

            string randomRank = iranianAgentsRanks[random.Next(0, 1)]; 

            IIranianAgent iranianAgent = null;

            switch (randomRank) 
            {
                case "junior":
                    iranianAgent = JuniorIranianAgentGenerator.GenerateAgent();
                 break;

                default:
                    Console.WriteLine();
                    break;

            }
            return iranianAgent;
        }

    }
}
