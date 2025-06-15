using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal interface ISensors
    {
        string SensorName { get; }

        bool Activate(IIranianAgent iranianAgent);
    }
}
