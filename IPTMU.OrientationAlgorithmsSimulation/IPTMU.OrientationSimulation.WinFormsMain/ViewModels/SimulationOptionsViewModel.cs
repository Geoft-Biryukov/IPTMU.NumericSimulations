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
        #region Common
        private double motionStep = 1e-2;
        [Localization.LocalizedCategory("SimulationOptionsCommonCategory")]
        [Localization.LocalizedDisplayName("SimulationOptionsMotionStep")]        
        public double MotionStep 
        {
            get => motionStep;
            set => Set(nameof(MotionStep), ref motionStep, value);
        }

        private double motionPeriod = 600;
        [Localization.LocalizedCategory("SimulationOptionsCommonCategory")]
        [Localization.LocalizedDisplayName("SimulationOptionsMotionPeriod")]
        public double MotionPeriod
        {
            get => motionPeriod;
            set => Set(nameof(MotionPeriod), ref motionPeriod, value);
        }

        private MotionTypes motionType = MotionTypes.ClassicalConicalPrecession;
        [Localization.LocalizedCategory("SimulationOptionsCommonCategory")]
        [Localization.LocalizedDisplayName("SimulationOptionsMotionType")]
        public MotionTypes MotionType
        {
            get => motionType;
            set => Set(nameof(MotionType), ref motionType, value);
        }

        private AlgorithmTypes algorithmType = AlgorithmTypes.Molodenkov;
        [Localization.LocalizedCategory("SimulationOptionsCommonCategory")]
        [Localization.LocalizedDisplayName("SimulationOptionsAlgorithmType")]
        public AlgorithmTypes AlgorithmType
        {
            get => algorithmType;
            set => Set(nameof(AlgorithmTypes), ref algorithmType, value);
        }
        #endregion

        #region Start orientation

        private double yaw = 0;
        [Localization.LocalizedCategory("SimulationOptionsStartOrientationCategory")]
        [Localization.LocalizedDisplayName("SimulationOptionsYaw")]
        /// <summary>
        /// Рысканье
        /// </summary>
        public double Yaw
        {
            get => yaw;
            set => Set(nameof(Yaw), ref yaw, value);
        }

        private double roll = 0;
        [Localization.LocalizedCategory("SimulationOptionsStartOrientationCategory")]
        [Localization.LocalizedDisplayName("SimulationOptionsRoll")]
        /// <summary>
        /// Крен
        /// </summary>
        public double Roll
        {
            get => roll;
            set => Set(nameof(Roll), ref roll, value);
        }

        private double pitch = 0;
        [Localization.LocalizedCategory("SimulationOptionsStartOrientationCategory")]
        [Localization.LocalizedDisplayName("SimulationOptionsPitch")]
        /// <summary>
        /// Тангаж
        /// </summary>
        public double Pitch
        {
            get => pitch;
            set => Set(nameof(Pitch), ref pitch, value);
        }
        #endregion
    }
}
