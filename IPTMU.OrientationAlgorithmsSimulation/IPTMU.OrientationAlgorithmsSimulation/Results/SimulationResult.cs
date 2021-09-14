using IPTMU.MathKernel.OrientationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithmsSimulation.Results
{
    public class SimulationResult
    {
        public double Time { get; set; }
        public Quaternion CalculatedOrientation { get; set; }
        public Quaternion ExactOrientation { get; set; }
        public Quaternion AngularVelocity { get; set; }
    }
}
