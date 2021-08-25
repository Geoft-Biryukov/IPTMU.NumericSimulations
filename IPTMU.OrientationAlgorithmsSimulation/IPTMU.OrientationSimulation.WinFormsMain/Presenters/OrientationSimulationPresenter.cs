using IPTMU.OrientationSimulation.WinFormsMain.Resources;
using IPTMU.OrientationSimulation.WinFormsMain.ViewModels;
using IPTMU.OrientationSimulation.WinFormsMain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.Presenters
{
    public class OrientationSimulationPresenter
    {
        private readonly IOrinetationSimulationView mainView;
        private readonly SimulationOptionsViewModel simulationOptions; 

        public OrientationSimulationPresenter(IOrinetationSimulationView mainView)
        {
            this.mainView = mainView ?? throw new ArgumentNullException(nameof(mainView));
            simulationOptions = new SimulationOptionsViewModel();

            mainView.BindSimulationOption(simulationOptions);
        }

        internal void ChangeLanguage(string language)
        {
            Utils.UpdateAppConfig.Update("language", language);

            mainView.ShowInformationMessage(GlobalStrings.RestartNeeded, GlobalStrings.InformationCaption);
        }
    }
}
