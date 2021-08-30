using IPTMU.MathKernel.OrientationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithmsSimulation.Options
{
    public class SimulatorOptions
    {
        public double MotionStep { get; set; }
        public double MotionTime { get; set; }
        public Quaternion StartOrientation { get; set; }
        //public OrientationAlgorithms Algorithm { get; set; }
        //public MotionSimulators MotionSimulator { get; set; }
    }
}
