using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal interface IIranianAgent
    {
        string Name { get; set; }

        string Rank { get;  }
        List<string> SensorsList { get; set; }


      
    }
}
