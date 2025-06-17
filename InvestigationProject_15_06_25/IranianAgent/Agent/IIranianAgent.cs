using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal interface IIranianAgent
    {
        int Id { get; set; }
        string Name { get; set; }

        string Rank { get; }
        List<string> SensitiveToSensors { get; set; }
        List<ISensors> AttachedSensors { get; set; }

        int Count { get; set; }

        void CounterStrike();




    }
}
