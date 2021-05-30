using IPTMU.AngularMotionSimulation.Abstract;
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
        private readonly double omegaCapital;
        private readonly Angle alpha;

        /// <summary>
        /// Классическое коническое движение
        /// </summary>
        /// <param name="omegaCapital">Круговая частота конического движения (рад/с)</param>
        /// <param name="alpha">Угол полураствора конуса</param>
        public ClassicalConingMotionSimulator(double omegaCapital, Angle alpha)
        {
            this.omegaCapital = omegaCapital;
            this.alpha = alpha;
        }

        public AngularMotion GetAngularMotion(double t)
        {
            if(t < 0)
                throw new ArgumentOutOfRangeException($"{nameof(t)} < 0");

            var alphaRad = alpha.Rad;

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

            return new AngularMotion(lambda, omega);
        }
    }
}
