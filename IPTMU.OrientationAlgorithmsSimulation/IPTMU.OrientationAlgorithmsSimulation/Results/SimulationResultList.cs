using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithmsSimulation.Results
{
    public class SimulationResultList : ISimulationResultStore
    {
        private readonly List<SimulationResult> results = new List<SimulationResult>();

        public void Add(SimulationResult result)
        {
            results.Add(result);
        }
    }
}
