using IPTMU.MathKernel.OrientationParameters;
using IPTMU.OrientationAlgorithms.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithms.Concrete.Molodenkov
{
    public class OrientationAlgorithm : IOrientationAlgorithm
    {
        public Quaternion Calculate(Quaternion lambdaPrevious, Quaternion omegaPrevious, Quaternion omegaCurrent)
        {
            throw new NotImplementedException();
        }
    }
}
