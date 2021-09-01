using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.AngularMotionSimulation.Logic.Concrete.AngularMotionParameters
{
    /// <summary>
    /// Классическая прецессия
    /// В.Н. Бранец, И.П. Шмыглевский
    /// omega = a * i1 * cos(b*t) + a * i2 * sin(b*t) + c
    /// </summary>
    public class ClassicalConicalPrecessionParameters
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
    }
}
