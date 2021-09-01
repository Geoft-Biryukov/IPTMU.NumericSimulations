using IPTMU.AngularMotionSimulation.Abstract;
using IPTMU.AngularMotionSimulation.Logic.Concrete.AngularMotionParameters;
using IPTMU.Auxiliaries.DataTypes;
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

        public ClassicalConicalPrecessionSimulator(ClassicalConicalPrecessionParameters parameters)
        {
            this.parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        public AngularState GetAngularMotion(double t)
        {
            throw new NotImplementedException();
        }
    }
}
