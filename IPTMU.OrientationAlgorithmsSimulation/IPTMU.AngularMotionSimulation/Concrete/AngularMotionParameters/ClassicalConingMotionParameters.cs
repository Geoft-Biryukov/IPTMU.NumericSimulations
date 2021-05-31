using IPTMU.MathKernel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters
{
    public class ClassicalConingMotionParameters
    {
        /// <summary>
        /// Круговая частота конического движения (рад/с)
        /// </summary>
        public double Omega { get; set; }
        /// <summary>
        /// Угол полураствора конуса
        /// </summary>
        public Angle Alpha { get; set; }
    }
}
