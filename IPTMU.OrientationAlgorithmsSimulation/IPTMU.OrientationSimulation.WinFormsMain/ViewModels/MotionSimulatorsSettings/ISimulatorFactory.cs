using IPTMU.AngularMotionSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.ViewModels.MotionSimulatorsSettings
{
    public interface ISimulatorFactory
    {
        IAngularMotionSimulator Create();
    }
}
