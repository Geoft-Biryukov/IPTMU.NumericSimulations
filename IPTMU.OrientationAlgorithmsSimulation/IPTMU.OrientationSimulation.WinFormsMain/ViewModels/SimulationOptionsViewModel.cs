using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTMU.OrientationSimulation.WinFormsMain.ViewModels
{
    public class SimulationOptionsViewModel : NotifyPropertyChangedImpl
    {
        private double motionStep = 1e-2;
        [Localization.LocolizedDisplayName("SimulationOptionsMotionStep")]
        public double MotionStep 
        {
            get => motionStep;
            set => Set(nameof(MotionStep), ref motionStep, value);
        }

        private double motionPeriod = 600;
        [DisplayName("Время движения (с)")]
        public double MotionPeriod
        {
            get => motionPeriod;
            set => Set(nameof(MotionPeriod), ref motionPeriod, value);
        }

        private MotionTypes motionType = MotionTypes.ClassicalConicalPrecession;
        public MotionTypes MotionType
        {
            get => motionType;
            set => Set(nameof(MotionType), ref motionType, value);
        }

        private AlgorithmTypes algorithmType = AlgorithmTypes.Molodenkov;
        public AlgorithmTypes AlgorithmType
        {
            get => algorithmType;
            set => Set(nameof(AlgorithmTypes), ref algorithmType, value);
        }
    }
}
