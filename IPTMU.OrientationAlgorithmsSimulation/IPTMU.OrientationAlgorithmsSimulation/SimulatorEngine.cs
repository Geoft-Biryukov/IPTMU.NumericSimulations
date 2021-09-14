using IPTMU.Auxiliaries.DataTypes;
using IPTMU.MathKernel.OrientationParameters;
using IPTMU.OrientationAlgorithms.Abstract;
using IPTMU.OrientationAlgorithmsSimulation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithmsSimulation
{
    public class SimulatorEngine
    {
        private readonly IEnumerable<AngularState> iterator;
        private readonly IOrientationAlgorithm algorithm;

        public SimulatorEngine(IEnumerable<AngularState> iterator, IOrientationAlgorithm algorithm)
        {
            this.iterator = iterator ?? throw new ArgumentNullException(nameof(iterator));
            this.algorithm = algorithm ?? throw new ArgumentNullException(nameof(algorithm));
        }

        public void StartSimulation(ISimulationResultStore store)
        {
            if (store is null) 
                throw new ArgumentNullException(nameof(store));

            var orientation = new Quaternion(1);

            foreach (var item in iterator)
            {
                var result = new SimulationResult
                {
                    CalculatedOrientation = algorithm.Calculate(orientation, item.AngularVelocity),
                    ExactOrientation = item.Orientation,
                    AngularVelocity = item.AngularVelocity
                };

                store.Add(result);                                
            }
        }

        public Task StartSimulationAsync(ISimulationResultStore store)
        {
            if (store is null) 
                throw new ArgumentNullException(nameof(store));
            
            return Task.Run(() => StartSimulation(store));
        }
    }
}
