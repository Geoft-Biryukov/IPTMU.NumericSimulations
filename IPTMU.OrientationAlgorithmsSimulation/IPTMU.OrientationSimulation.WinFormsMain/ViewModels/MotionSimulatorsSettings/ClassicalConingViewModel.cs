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
    public class ClassicalConingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ClassicalConingMotionParameters motionParameters;

        public ClassicalConingViewModel(ClassicalConingMotionParameters motionParameters)
        {
            this.motionParameters = motionParameters ?? throw new ArgumentNullException(nameof(motionParameters));
        }

        [LocalizedDisplayName("ClassicalConingAngularFrequency")]
        public double Omega
        {
            get => Math.Round(motionParameters.Omega, 7);
            set
            {
                if (motionParameters.Omega == value)
                    return;

                motionParameters.Omega = value;
                RaisePropertyChanged(nameof(Omega));
            }
        }

        [LocalizedDisplayName("ConingAngle")]
        public double Alpha
        {
            get => Math.Round(motionParameters.Alpha.Deg, 3);
            set
            {
                if (motionParameters.Alpha.Deg == value)
                    return;

                motionParameters.Alpha = Angle.FromDeg(value);
                RaisePropertyChanged(nameof(Alpha));                
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
