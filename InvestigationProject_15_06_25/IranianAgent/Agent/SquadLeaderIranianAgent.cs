using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25.IranianAgent.Agent
{
    internal class SquadLeaderIranianAgent : IIranianAgent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; } = "Squad Leader";
        public List<string> SensitiveToSensors { get; set; } = new List<string>(); // new List<string>(4) -   רק 4 סנסורים לחשיפה
        public List<ISensors> AttachedSensors { get; set; } = new List<ISensors>();

        public int Count { get; set; } = 0;

        public void CounterStrike()
        {
            if (Count == 3)
            {
                Count = 0;
                if (AttachedSensors.Count > 0) { AttachedSensors.RemoveAt(AttachedSensors.Count - 1); }
            }

        }

    }
}
