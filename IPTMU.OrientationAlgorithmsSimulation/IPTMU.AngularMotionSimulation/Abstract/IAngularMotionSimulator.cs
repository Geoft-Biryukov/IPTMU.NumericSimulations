using IPTMU.Auxiliaries.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.AngularMotionSimulation.Abstract
{
    public interface IAngularMotionSimulator
    {
        AngularState GetAngularMotion(double t);
    }
}
