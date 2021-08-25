using IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters;
using IPTMU.MathKernel.Common;
using IPTMU.OrientationSimulation.WinFormsMain.Resources;
using IPTMU.OrientationSimulation.WinFormsMain.ViewModels;
using IPTMU.OrientationSimulation.WinFormsMain.ViewModels.MotionSimulatorsSettings;
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

        private readonly Dictionary<MotionTypes, object> motionOptions = new Dictionary<MotionTypes, object>();

        public OrientationSimulationPresenter(IOrinetationSimulationView mainView)
        {
            this.mainView = mainView ?? throw new ArgumentNullException(nameof(mainView));
            simulationOptions = new SimulationOptionsViewModel();

            mainView.BindSimulationOption(simulationOptions);

            simulationOptions.PropertyChanged += SimulationOptionsPropertyChanged;

            InitializeMotionOptions();

            mainView.SetMotionSettings(motionOptions[simulationOptions.MotionType]);
        }

        private void InitializeMotionOptions()
        {
            var classicalConingParameters = new ClassicalConingMotionParameters
            {
                Alpha = Angle.FromDeg(30),
                Omega = Math.PI / 6
            };
            motionOptions[MotionTypes.ClassicalConicalPrecession] = new ClassicalConingViewModel(classicalConingParameters);

            var generalizedConingParameters = new GeneralizedConicalPrecessionParameters
            {
                
            };
            motionOptions[MotionTypes.GeneralizedConicalPrecession] = null; 
        }
        
        private void SimulationOptionsPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals(nameof(SimulationOptionsViewModel.MotionType)))
            {
                mainView.SetMotionSettings(motionOptions[simulationOptions.MotionType]);
            }
        }

        internal void ChangeLanguage(string language)
        {
            Localization.UpdateAppConfig.Update("language", language);
            mainView.ShowInformationMessage(GlobalStrings.RestartNeeded, GlobalStrings.InformationCaption);
        }
        
        internal void StartSimulation()
        {
            
        }
    }
}
