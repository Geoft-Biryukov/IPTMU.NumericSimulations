using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.ViewModels.MotionSimulatorsSettings
{
    public interface IParametersWrapper<out T>
    {
        T Parameters { get; }
    }
}
