using IPTMU.AngularMotionSimulation.Concrete.AngularMotionParameters;
using IPTMU.MathKernel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.ViewModels
{
    public class ClassicalConingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ClassicalConingMotionParameters motionParameters;

        public ClassicalConingViewModel(ClassicalConingMotionParameters motionParameters)
        {
            this.motionParameters = motionParameters ?? throw new ArgumentNullException(nameof(motionParameters));
        }

        [DisplayName("Круговая частота (рад/с)")]
        public double Omega
        {
            get => motionParameters.Omega;
            set
            {
                if (motionParameters.Omega == value)
                    return;

                motionParameters.Omega = value;
                RaisePropertyChanged(nameof(Omega));
            }
        }

        [DisplayName("Угол полураствора конуса (гр)")]
        public double Alpha
        {
            get => motionParameters.Alpha.Deg;
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
