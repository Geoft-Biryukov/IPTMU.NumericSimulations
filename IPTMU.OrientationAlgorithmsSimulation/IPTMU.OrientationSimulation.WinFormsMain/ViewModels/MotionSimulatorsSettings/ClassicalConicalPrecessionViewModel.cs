using IPTMU.AngularMotionSimulation.Abstract;
using IPTMU.AngularMotionSimulation.Concrete;
using IPTMU.AngularMotionSimulation.Logic.Concrete.AngularMotionParameters;
using IPTMU.OrientationSimulation.WinFormsMain.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.ViewModels.MotionSimulatorsSettings
{
    public class ClassicalConicalPrecessionViewModel : INotifyPropertyChanged, IParametersWrapper<ClassicalConicalPrecessionParameters>, ISimulatorFactory
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ClassicalConicalPrecessionViewModel(ClassicalConicalPrecessionParameters motionParameters)
        {
            Parameters = motionParameters ?? throw new ArgumentNullException(nameof(motionParameters));
        }

        [LocalizedDisplayName("ClassicalConialPrecessionA")]
        public double A
        {
            get => Math.Round(Parameters.A, 7);
            set
            {
                if (Parameters.A == value)
                    return;

                Parameters.A = value;
                RaisePropertyChanged(nameof(A));
            }
        }

        [LocalizedDisplayName("ClassicalConialPrecessionB")]
        public double B
        {
            get => Math.Round(Parameters.B, 7);
            set
            {
                if (Parameters.B == value)
                    return;

                Parameters.B = value;
                RaisePropertyChanged(nameof(B));
            }
        }

        [LocalizedDisplayName("ClassicalConialPrecessionC")]
        public double C
        {
            get => Math.Round(Parameters.C, 7);
            set
            {
                if (Parameters.C == value)
                    return;

                Parameters.C = value;
                RaisePropertyChanged(nameof(C));
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IAngularMotionSimulator Create() => new ClassicalConicalPrecessionSimulator(Parameters);


        [Browsable(false)]
        public ClassicalConicalPrecessionParameters Parameters { get; }
    }
}
