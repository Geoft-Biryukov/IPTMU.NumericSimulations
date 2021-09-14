using IPTMU.AngularMotionSimulation.Abstract;
using IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters;
using IPTMU.Auxiliaries.DataTypes;
using IPTMU.MathKernel.OrientationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.AngularMotionSimulation.Concrete
{
    /// <summary>
    /// Обобщенная коническое движение
    /// Молоденков А.В.
    /// </summary>
    public class GeneralizedConicalPrecessionSimulator : IAngularMotionSimulator
    {
        private readonly GeneralizedConicalPrecessionParameters motionParameters;

        public GeneralizedConicalPrecessionSimulator(GeneralizedConicalPrecessionParameters motionParameters)
        {
            this.motionParameters = motionParameters ?? throw new ArgumentNullException(nameof(motionParameters));
        }

        public AngularState GetAngularMotion(double t)
        {
            var f = motionParameters.F(t);
            var g = motionParameters.G(t);

            var fDot = motionParameters.Fdot(t);
            var gDot = motionParameters.Gdot(t);

            var innerOmega = new Quaternion(0, fDot * Math.Sin(g), fDot * Math.Cos(g), gDot);

            var k = motionParameters.K;
            var omega = Quaternion.Conjugate(k) * innerOmega * k;

            var f0 = motionParameters.F(0);
            var g0 = motionParameters.G(0);

            var q1 = new Quaternion(0, 0, 0, -0.5 * g0);
            var q2 = new Quaternion(0, 0, 0.5 * (f - f0), 0);
            var q3 = new Quaternion(0, 0, 0, 0.5 * g);

            var innerLambda = Quaternion.Exp(q1) * Quaternion.Exp(q2) * Quaternion.Exp(q3);

            var lambda = motionParameters.Lambda0 * Quaternion.Conjugate(k) * innerLambda * k;

            return new AngularState(t, lambda, omega);
            
        }
    }
}
