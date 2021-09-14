using IPTMU.MathKernel.OrientationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.Auxiliaries.DataTypes
{
    public class AngularState
    {
        public AngularState(double time, Quaternion orientation, Quaternion angularVelocity)
        {
            Time = time;
            Orientation = orientation;
            AngularVelocity = angularVelocity;
        }

        public double Time { get; }
        public Quaternion Orientation { get; }
        public Quaternion AngularVelocity { get; }
    }
}
