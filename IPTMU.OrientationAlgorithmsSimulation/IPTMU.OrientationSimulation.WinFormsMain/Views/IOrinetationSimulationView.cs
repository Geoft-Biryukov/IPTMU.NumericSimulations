using IPTMU.OrientationSimulation.WinFormsMain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.Views
{
    public interface IOrinetationSimulationView
    {
        void ShowInformationMessage(string message, string caption);
        void BindSimulationOption(SimulationOptionsViewModel model);
    }
}
