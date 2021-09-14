using IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters;
using IPTMU.AngularMotionSimulation.Logic.Concrete.AngularMotionParameters;
using IPTMU.MathKernel.Common;
using IPTMU.OrientationAlgorithms.Abstract;
using IPTMU.OrientationAlgorithmsSimulation;
using IPTMU.OrientationAlgorithmsSimulation.Options;
using IPTMU.OrientationAlgorithmsSimulation.Results;
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

        private readonly Dictionary<MotionTypes, ISimulatorFactory> motionOptions = new Dictionary<MotionTypes, ISimulatorFactory>();

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
            motionOptions[MotionTypes.ClassicalConingMotion] = new ClassicalConingViewModel(classicalConingParameters);

            //var generalizedConingParameters = new GeneralizedConicalPrecessionParameters
            //{
                
            //};
            //motionOptions[MotionTypes.GeneralizedConicalPrecession] = null;

            var classicalPrecessionParameters = new ClassicalConicalPrecessionParameters
            {
                A = 1, B = Math.PI, C = 1
            };
            motionOptions[MotionTypes.ClassicalConicalPrecession] = new ClassicalConicalPrecessionViewModel(classicalPrecessionParameters);

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
        
        async internal void StartSimulation()
        {
            var simulator = motionOptions[simulationOptions.MotionType].Create();
            var algorithm = CreateAlgorithm();

            var options = new SimulatorOptions
            {
                MotionTime = simulationOptions.MotionPeriod, 
                MotionStep = simulationOptions.MotionStep
            };

            var iterator = new MotionIterator(options, simulator);

            var engine = new SimulatorEngine(iterator, algorithm);

            var results = new SimulationResultList();

            await engine.StartSimulationAsync(results);

            int i = 0;
        }

        private IOrientationAlgorithm CreateAlgorithm()
        {
            switch (simulationOptions.AlgorithmType)
            {
                case AlgorithmTypes.Molodenkov:
                    return new OrientationAlgorithms.Concrete.Molodenkov.OrientationAlgorithm(simulationOptions.MotionStep);                    
                
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
