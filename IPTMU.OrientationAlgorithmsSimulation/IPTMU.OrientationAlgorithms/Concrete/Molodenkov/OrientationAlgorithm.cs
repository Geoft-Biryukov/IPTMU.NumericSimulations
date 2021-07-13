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

            var nuCaps = nu * step;
            var muCaps = mu * step;

            var w = new Quaternion(0, -mu * Math.Sin(nuCaps), mu * Math.Cos(nuCaps), -2 * nu);

            var arg1 = new Quaternion(0, 0, muCaps / 4, 0);
            var arg2 = new Quaternion(0, 0, 0, -nuCaps / 2);

            var phiCaps = Quaternion.Exp(arg1) * Quaternion.Exp(arg2);

            var thetaStar = kappa * phiCaps.Conjugate() * step * (phiCaps * w * phiCaps.Conjugate()) * phiCaps * kappa.Conjugate() / 4;

            var thetaStarNorm = thetaStar.Vect().Norm();

            var e = thetaStar.Vect() / thetaStarNorm;
            var phi = 4.0 * Math.Atan(thetaStarNorm);

            var sin = Math.Sin(0.5 * phi);
            var u = new Quaternion(Math.Cos(0.5 * phi), sin * e[1], sin * e[2], sin * e[3]);

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
