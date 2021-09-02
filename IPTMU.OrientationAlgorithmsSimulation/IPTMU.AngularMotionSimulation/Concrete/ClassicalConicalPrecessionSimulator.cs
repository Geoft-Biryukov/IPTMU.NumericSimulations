using IPTMU.AngularMotionSimulation.Abstract;
using IPTMU.AngularMotionSimulation.Logic.Concrete.AngularMotionParameters;
using IPTMU.Auxiliaries.DataTypes;
using IPTMU.MathKernel.OrientationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.AngularMotionSimulation.Logic.Concrete
{
    /// <summary>
    /// Классическая прецессия
    /// В.Н. Бранец, И.П. Шмыглевский
    /// omega = a * i1 * cos(b * t) + a * i2 * sin(b * t) + c * i3
    /// lambda = exp(B * t / 2) * exp((omega0 - B) * t / 2), 
    /// где B = b * i3
    /// </summary>
    public class ClassicalConicalPrecessionSimulator : IAngularMotionSimulator
    {
        private readonly ClassicalConicalPrecessionParameters parameters;
        private readonly Quaternion omega0;

        public ClassicalConicalPrecessionSimulator(ClassicalConicalPrecessionParameters parameters)
        {
            this.parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));

            omega0 = CalculateOmega(0);
        }

        public AngularState GetAngularMotion(double t)
        {
            if (t < 0)
                throw new ArgumentOutOfRangeException($"{nameof(t)} < 0");

            var omega = CalculateOmega(t);
            var lambda = CalculateLambda(t);

            return new AngularState(lambda, omega);
        }

        private Quaternion CalculateOmega(double t)
        {
            var a = parameters.A;
            var b = parameters.B;
            var c = parameters.C;

            return new Quaternion(0, a * Math.Cos(b * t), a * Math.Sin(b * t), c);
        }

        private Quaternion CalculateLambda(double t)
        {
            var b = parameters.B * Quaternion.I3();
            return  Quaternion.Exp(0.5 * (b - omega0) * t) * Quaternion.Exp(0.5 * b * t);
        }
    }
}
