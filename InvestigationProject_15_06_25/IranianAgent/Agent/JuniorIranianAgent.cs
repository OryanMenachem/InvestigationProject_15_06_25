﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{

    internal class JuniorIranianAgent : IIranianAgent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; } = "Junior";
        public List<string> SensitiveToSensors { get; set; } = new List<string>(); // new List<string>(2) -  רק שני סנסורים לחשיפה
        public List<ISensors> AttachedSensors { get; set; } = new List<ISensors>();

        public int Count { get; set; }

        public void CounterStrike() { }




    }
}
