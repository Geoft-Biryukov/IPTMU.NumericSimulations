﻿using IPTMU.MathKernel.OrientationParameters;
using IPTMU.OrientationAlgorithms.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithms.Concrete
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
            throw new NotImplementedException();
        }
    }
}
