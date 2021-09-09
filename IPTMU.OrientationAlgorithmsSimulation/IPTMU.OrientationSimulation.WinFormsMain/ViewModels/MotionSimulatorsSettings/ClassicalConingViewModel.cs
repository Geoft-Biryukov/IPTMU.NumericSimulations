using IPTMU.AngularMotionSimulation.Abstract;
using IPTMU.AngularMotionSimulation.Concrete;
using IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters;
using IPTMU.MathKernel.Common;
using IPTMU.OrientationSimulation.WinFormsMain.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.ViewModels.MotionSimulatorsSettings
{
    public class ClassicalConingViewModel : INotifyPropertyChanged, IParametersWrapper<ClassicalConingMotionParameters>, ISimulatorFactory
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ClassicalConingViewModel(ClassicalConingMotionParameters motionParameters)
        {
            Parameters = motionParameters ?? throw new ArgumentNullException(nameof(motionParameters));
        }

        [LocalizedDisplayName("ClassicalConingAngularFrequency")]
        public double Omega
        {
            get => Math.Round(Parameters.Omega, 7);
            set
            {
                if (Parameters.Omega == value)
                    return;

                Parameters.Omega = value;
                RaisePropertyChanged(nameof(Omega));
            }
        }

        [LocalizedDisplayName("ConingAngle")]
        public double Alpha
        {
            get => Math.Round(Parameters.Alpha.Deg, 3);
            set
            {
                if (Parameters.Alpha.Deg == value)
                    return;

                Parameters.Alpha = Angle.FromDeg(value);
                RaisePropertyChanged(nameof(Alpha));                
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IAngularMotionSimulator Create() 
            => new ClassicalConingMotionSimulator(Parameters);


        [Browsable(false)]
        public ClassicalConingMotionParameters Parameters { get; }
    }
}
