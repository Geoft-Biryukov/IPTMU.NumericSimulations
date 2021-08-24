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

namespace IPTMU.OrientationSimulation.WinFormsMain
{
    public partial class OrientationSimulationMainForm : Form, IOrinetationSimulationView
    {
        private readonly OrientationSimulationPresenter presenter;

        public OrientationSimulationMainForm()
        {
            InitializeComponent();

            presenter = new OrientationSimulationPresenter(this);            
        }

        public void ShowInformationMessage(string message)
        {
            MessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.ChangeLanguage("en");
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.ChangeLanguage("ru");
        }
    }
}
