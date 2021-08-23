using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithmsSimulation.Options
{
    internal class SimulatorOptions
    {
        public double IntegrationStep { get; set; }
        public double MotionTime { get; set; }
        public OrientationAlgorithms Algorithm { get; set; }
        public MotionSimulators MotionSimulator { get; set; }
    }
}
