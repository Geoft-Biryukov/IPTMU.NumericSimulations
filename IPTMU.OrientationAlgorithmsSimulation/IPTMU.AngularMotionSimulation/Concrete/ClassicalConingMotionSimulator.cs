using IPTMU.AngularMotionSimulation.Abstract;
using IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters;
using IPTMU.Auxiliaries.DataTypes;
using IPTMU.MathKernel.Common;
using IPTMU.MathKernel.OrientationParameters;
using System;

namespace IPTMU.AngularMotionSimulation.Concrete
{
    /// <summary>
    /// Классическое коническое движение
    /// По материалам статьи:
    /// Yuanxin Wu, Yury A. Litmanovich Strapdown Attitude Computation: 
    /// Functional Iterative Integration versus Taylor Series Expansion 
    /// </summary>
    public class ClassicalConingMotionSimulator : IAngularMotionSimulator
    {       
        private readonly ClassicalConingMotionParameters motionParameters;              

        /// <summary>
        /// Классическое коническое движение
        /// </summary>
        /// <param name="motionParameters"></param>
        public ClassicalConingMotionSimulator(ClassicalConingMotionParameters motionParameters)
        {
            this.motionParameters = motionParameters ?? throw new ArgumentNullException(nameof(motionParameters));
        }

        public AngularState GetAngularMotion(double t)
        {
            if(t < 0)
                throw new ArgumentOutOfRangeException($"{nameof(t)} < 0");

            var alphaRad = motionParameters.Alpha.Rad;
            var omegaCapital = motionParameters.Omega;

            var omega = new Quaternion(
                0,
                -2 * Math.Sin(0.5 * alphaRad) * Math.Sin(0.5 * alphaRad),
                -Math.Sin(alphaRad) * Math.Sin(omegaCapital * t),
                Math.Sin(alphaRad) * Math.Cos(omegaCapital * t));

            var lambda = new Quaternion(
                Math.Cos(0.5 * alphaRad), 
                0, 
                Math.Sin(0.5 * alphaRad) * Math.Cos(omegaCapital * t),
                Math.Sin(0.5 * alphaRad) * Math.Sin(omegaCapital * t));

            return new AngularState(t, lambda, omega);
        }
    }
}
