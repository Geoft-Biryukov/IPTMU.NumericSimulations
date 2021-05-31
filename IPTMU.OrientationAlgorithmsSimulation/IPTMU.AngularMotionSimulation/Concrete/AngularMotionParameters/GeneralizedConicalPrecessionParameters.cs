using IPTMU.MathKernel.OrientationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters
{
    public class GeneralizedConicalPrecessionParameters
    {
        /// <summary>
        /// Постоянный кватернион
        /// </summary>
        public Quaternion K { get; set; }
        /// <summary>
        /// Кватернион начальной ориентации
        /// </summary>
        public Quaternion Lambda0 { get; set; }
        /// <summary>
        /// Произвольная функция времени f(t)
        /// </summary>
        public Func<double, double> F { get; set; }
        /// <summary>
        /// Произвольная функция времени g(t)
        /// </summary>
        public Func<double, double> G { get; set; }
        /// <summary>
        /// Производная повремени f'(t)
        /// </summary>
        public Func<double, double> Fdot { get; set; }
        /// <summary>
        /// Производная повремени g'(t)
        /// </summary>
        public Func<double, double> Gdot { get; set; }

    }
}
