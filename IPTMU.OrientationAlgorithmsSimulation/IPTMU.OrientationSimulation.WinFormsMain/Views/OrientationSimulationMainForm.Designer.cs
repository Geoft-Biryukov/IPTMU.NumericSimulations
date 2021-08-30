
namespace IPTMU.OrientationSimulation.WinFormsMain.Views
{
    partial class OrientationSimulationMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrientationSimulationMainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.motionStepNumeric = new System.Windows.Forms.NumericUpDown();
            this.motionTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.motionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.generalSettingsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.motionSettingsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simulationOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motionStepNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motionTimeNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationOptionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.RussianToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.motionStepNumeric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.motionTimeNumeric, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.motionTypeComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.algorithmComboBox, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // motionStepNumeric
            // 
            this.motionStepNumeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.simulationOptionsBindingSource, "MotionStep", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.motionStepNumeric.DecimalPlaces = 4;
            resources.ApplyResources(this.motionStepNumeric, "motionStepNumeric");
            this.motionStepNumeric.Name = "motionStepNumeric";
            // 
            // motionTimeNumeric
            // 
            this.motionTimeNumeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.simulationOptionsBindingSource, "MotionPeriod", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.motionTimeNumeric.DecimalPlaces = 2;
            resources.ApplyResources(this.motionTimeNumeric, "motionTimeNumeric");
            this.motionTimeNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.motionTimeNumeric.Name = "motionTimeNumeric";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // motionTypeComboBox
            // 
            this.motionTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simulationOptionsBindingSource, "MotionType", true));
            resources.ApplyResources(this.motionTypeComboBox, "motionTypeComboBox");
            this.motionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motionTypeComboBox.FormattingEnabled = true;
            this.motionTypeComboBox.Name = "motionTypeComboBox";
            this.motionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MotionTypeComboBox_SelectedIndexChanged);
            // 
            // algorithmComboBox
            // 
            resources.ApplyResources(this.algorithmComboBox, "algorithmComboBox");
            this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmComboBox_SelectedIndexChanged);
            // 
            // generalSettingsPropertyGrid
            // 
            resources.ApplyResources(this.generalSettingsPropertyGrid, "generalSettingsPropertyGrid");
            this.generalSettingsPropertyGrid.Name = "generalSettingsPropertyGrid";
            this.generalSettingsPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            // 
            // motionSettingsPropertyGrid
            // 
            resources.ApplyResources(this.motionSettingsPropertyGrid, "motionSettingsPropertyGrid");
            this.motionSettingsPropertyGrid.Name = "motionSettingsPropertyGrid";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generalSettingsPropertyGrid);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.motionSettingsPropertyGrid);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // simulationOptionsBindingSource
            // 
            this.simulationOptionsBindingSource.DataSource = typeof(IPTMU.OrientationSimulation.WinFormsMain.ViewModels.SimulationOptionsViewModel);
            // 
            // OrientationSimulationMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "OrientationSimulationMainForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motionStepNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motionTimeNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simulationOptionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown motionStepNumeric;
        private System.Windows.Forms.NumericUpDown motionTimeNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox motionTypeComboBox;
        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.BindingSource simulationOptionsBindingSource;
        private System.Windows.Forms.PropertyGrid generalSettingsPropertyGrid;
        private System.Windows.Forms.PropertyGrid motionSettingsPropertyGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

