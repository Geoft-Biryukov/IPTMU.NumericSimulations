using IPTMU.MathKernel.OrientationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithms.Abstract
{
    public interface IOrientationAlgorithm
    {
        Quaternion Calculate(Quaternion lambdaPrevious, Quaternion omega);
    }
}
