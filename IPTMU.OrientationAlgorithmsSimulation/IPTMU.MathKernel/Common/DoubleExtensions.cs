using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.MathKernel.Common
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Преобразовать число в градусах в угол
        /// </summary>
        /// <param name="degrees">Число в градусах</param>
        /// <returns></returns>
        public static Angle AsAngleInDeg(this double degrees)
            => Angle.FromDeg(degrees);


        /// <summary>
        /// Преобразовать число в радианах в угол
        /// </summary>
        /// <param name="radians">Число в радианах</param>
        /// <returns></returns>
        public static Angle AsAngleInRad(this double radians)
            => Angle.FromRad(radians);
    }
}
