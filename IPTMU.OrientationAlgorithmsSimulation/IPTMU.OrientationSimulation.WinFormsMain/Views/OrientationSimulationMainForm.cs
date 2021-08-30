using IPTMU.OrientationSimulation.WinFormsMain.Presenters;
using IPTMU.OrientationSimulation.WinFormsMain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTMU.OrientationSimulation.WinFormsMain.Views
{
    public partial class OrientationSimulationMainForm : Form, IOrinetationSimulationView
    {
        private readonly OrientationSimulationPresenter presenter;
        private SimulationOptionsViewModel model;

        public OrientationSimulationMainForm()
        {
            InitializeComponent();

            presenter = new OrientationSimulationPresenter(this);
            
        }

        public void BindSimulationOption(SimulationOptionsViewModel model)
        {
            simulationOptionsBindingSource.DataSource = this.model =  model ?? throw new ArgumentNullException(nameof(model));

            motionTypeComboBox.DataSource = Enum.GetValues(model.MotionType.GetType());
            algorithmComboBox.DataSource = Enum.GetValues(model.AlgorithmType.GetType());

            generalSettingsPropertyGrid.SelectedObject = model;
        }

        public void ShowInformationMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.ChangeLanguage("en");
        }

        private void RussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.ChangeLanguage("ru");
        }
        
        private void StartButton_Click(object sender, EventArgs e)
        {
            presenter.StartSimulation();
        }

        private void MotionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(motionTypeComboBox.SelectedValue.ToString(), out MotionTypes motionType))
            {
                model.MotionType = motionType;
            }
        }

        private void AlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(algorithmComboBox.SelectedValue.ToString(), out AlgorithmTypes algorithmType))
            {
                model.AlgorithmType = algorithmType;
            }
        }

        public void SetMotionSettings(object dataSource)
        {
            motionSettingsPropertyGrid.SelectedObject = dataSource;
        }
       
    }
}
