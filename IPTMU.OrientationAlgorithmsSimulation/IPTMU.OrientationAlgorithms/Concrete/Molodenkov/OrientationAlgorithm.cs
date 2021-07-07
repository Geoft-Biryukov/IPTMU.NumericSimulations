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
        private readonly double step;

        public OrientationAlgorithm(double step)
        {
            this.step = step;
        }

        public Quaternion Calculate(Quaternion lambdaPrevious, Quaternion omega)
        {
            var kappa = lambdaPrevious * (-Quaternion.I2());

            var (omega1Caps, mu, nu) = GetAuxiliaries(omega);

            throw new NotImplementedException();
        }

        private (double omega1Caps, double mu, double nu) GetAuxiliaries(Quaternion omega)
        {
            var omega1Caps = omega[1] * step;
            var mu = omega[2] * Math.Cos(omega1Caps) - omega[3] * Math.Sin(omega1Caps);
            var nu = omega[2] * Math.Sin(omega1Caps) + omega[3] * Math.Cos(omega1Caps);

            return (omega1Caps, mu, nu);
        }
    }
}
