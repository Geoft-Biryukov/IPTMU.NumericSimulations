using IPTMU.AngularMotionSimulation.Abstract;
using IPTMU.Auxiliaries.DataTypes;
using IPTMU.OrientationAlgorithmsSimulation.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithmsSimulation
{
    public class MotionIterator : IEnumerable<AngularState>
    {
        private readonly SimulatorOptions options;
        private readonly IAngularMotionSimulator simulator;

        public MotionIterator(SimulatorOptions options, IAngularMotionSimulator simulator)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
            this.simulator = simulator ?? throw new ArgumentNullException(nameof(simulator));
        }

        public IEnumerator<AngularState> GetEnumerator()
        {
            double t = 0;
            while(t < options.MotionTime)
            {
                t += options.MotionStep;
                yield return simulator.GetAngularMotion(t);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
