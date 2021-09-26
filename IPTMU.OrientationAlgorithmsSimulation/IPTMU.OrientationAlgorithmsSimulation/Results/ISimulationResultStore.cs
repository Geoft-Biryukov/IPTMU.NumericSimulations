using System.Collections.Generic;

namespace IPTMU.OrientationAlgorithmsSimulation.Results
{
    public interface ISimulationResultStore
    {
        void Add(SimulationResult result);
        IEnumerable<SimulationResult> Results { get; }
    }
}