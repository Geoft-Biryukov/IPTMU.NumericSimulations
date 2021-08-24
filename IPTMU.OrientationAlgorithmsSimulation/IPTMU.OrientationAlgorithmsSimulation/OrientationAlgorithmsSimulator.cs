
using IPTMU.OrientationAlgorithms.Abstract;
using IPTMU.OrientationAlgorithmsSimulation.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationAlgorithmsSimulation
{
    internal class OrientationAlgorithmsSimulator
    {
        
        public void StartSimulation(SimulatorOptions options)
        {
            if (options is null) 
                throw new ArgumentNullException(nameof(options));

            var algorithm = CreateAlgorithm(options.Algorithm, options.IntegrationStep);
           // IAngularMotionSimulator motionSimulator = CreateMotionSimulator(options.MotionSimulator);
        }        

        private IOrientationAlgorithm CreateAlgorithm(Options.OrientationAlgorithms algorithm, double integrationStep)
        {
            switch (algorithm)
            {
                case Options.OrientationAlgorithms.Molodenkov:
                    return new OrientationAlgorithms.Concrete.Molodenkov.OrientationAlgorithm(integrationStep);
                default:
                    throw new NotSupportedException();
            }
        }

        //private IAngularMotionSimulator CreateMotionSimulator(MotionSimulators motionSimulator)
        //{
        //    switch (motionSimulator)
        //    {
        //        case MotionSimulators.ClassicalConingMotion:
        //            return new ClassicalConingMotionSimulator()
        //        case MotionSimulators.GeneralizedConicalPrecession:
        //            break;
        //        default:
        //            throw new NotSupportedException(nameof(MotionSimulators));
        //    }
        //}
    }
}
