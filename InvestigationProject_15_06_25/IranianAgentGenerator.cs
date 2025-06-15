using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class IranianAgentGenerator
    {
        private static Random random = new Random();
        public static IIranianAgent GetIranianAgent()
        {
            IIranianAgent iranianAgent = null;

            switch (random.Next(0,1)) //
            {
                case 0:
                    iranianAgent = new JuniorIranianAgent("h",new List<ISensors>());
                    break;


            }
            return iranianAgent;
        }

    }
}
