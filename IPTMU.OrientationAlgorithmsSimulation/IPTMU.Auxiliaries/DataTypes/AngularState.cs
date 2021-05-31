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
        public AngularState(Quaternion orientation, Quaternion angularVelocity)
        {
            Orientation = orientation;
            AngularVelocity = angularVelocity;
        }

        public Quaternion Orientation { get; }
        public Quaternion AngularVelocity { get; }
    }
}
