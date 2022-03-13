namespace TimeSeriesTrainer
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleMovingAverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solutionDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.trainerParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatafileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.iterationPerUpdateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.momentumBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alphaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.learningRateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.windowSizeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCurrentIteration = new System.Windows.Forms.GroupBox();
            this.currentPredictionErrorBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.currentLearningErrorBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.currentIterationBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbPrediction = new System.Windows.Forms.GroupBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.startingPointBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.predictionSizeBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.loadNetworkDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbCurrentIteration.SuspendLayout();
            this.gbPrediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(999, 552);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.Chart1_AxisViewChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.trainerToolStripMenuItem,
            this.showToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNetworkToolStripMenuItem,
            this.loadDatafileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveNetworkToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadNetworkToolStripMenuItem
            // 
            this.loadNetworkToolStripMenuItem.Name = "loadNetworkToolStripMenuItem";
            this.loadNetworkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadNetworkToolStripMenuItem.Text = "Load network...";
            this.loadNetworkToolStripMenuItem.Click += new System.EventHandler(this.LoadNetworkToolStripMenuItem_Click);
            // 
            // loadDatafileToolStripMenuItem
            // 
            this.loadDatafileToolStripMenuItem.Name = "loadDatafileToolStripMenuItem";
            this.loadDatafileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadDatafileToolStripMenuItem.Text = "Load datafile...";
            this.loadDatafileToolStripMenuItem.Click += new System.EventHandler(this.LoadDatafileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // saveNetworkToolStripMenuItem
            // 
            this.saveNetworkToolStripMenuItem.Name = "saveNetworkToolStripMenuItem";
            this.saveNetworkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveNetworkToolStripMenuItem.Text = "Save network...";
            this.saveNetworkToolStripMenuItem.Click += new System.EventHandler(this.SaveNetworkToolStripMenuItem_Click);
            // 
            // trainerToolStripMenuItem
            // 
            this.trainerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.trainerToolStripMenuItem.Name = "trainerToolStripMenuItem";
            this.trainerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.trainerToolStripMenuItem.Text = "Trainer";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Enabled = false;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainerDataToolStripMenuItem,
            this.simpleMovingAverageToolStripMenuItem,
            this.solutionDataToolStripMenuItem,
            this.predictionDataToolStripMenuItem,
            this.toolStripMenuItem1,
            this.trainerParamsToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // trainerDataToolStripMenuItem
            // 
            this.trainerDataToolStripMenuItem.Checked = true;
            this.trainerDataToolStripMenuItem.CheckOnClick = true;
            this.trainerDataToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trainerDataToolStripMenuItem.Name = "trainerDataToolStripMenuItem";
            this.trainerDataToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.trainerDataToolStripMenuItem.Text = "Trainer data";
            this.trainerDataToolStripMenuItem.Click += new System.EventHandler(this.TrainerDataToolStripMenuItem_Click_1);
            // 
            // simpleMovingAverageToolStripMenuItem
            // 
            this.simpleMovingAverageToolStripMenuItem.Checked = true;
            this.simpleMovingAverageToolStripMenuItem.CheckOnClick = true;
            this.simpleMovingAverageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simpleMovingAverageToolStripMenuItem.Name = "simpleMovingAverageToolStripMenuItem";
            this.simpleMovingAverageToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.simpleMovingAverageToolStripMenuItem.Text = "Simple moving average";
            this.simpleMovingAverageToolStripMenuItem.Click += new System.EventHandler(this.SimpleMovingAverageToolStripMenuItem_Click);
            // 
            // solutionDataToolStripMenuItem
            // 
            this.solutionDataToolStripMenuItem.Checked = true;
            this.solutionDataToolStripMenuItem.CheckOnClick = true;
            this.solutionDataToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solutionDataToolStripMenuItem.Name = "solutionDataToolStripMenuItem";
            this.solutionDataToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.solutionDataToolStripMenuItem.Text = "Solution data";
            this.solutionDataToolStripMenuItem.Click += new System.EventHandler(this.SolutionDataToolStripMenuItem_Click);
            // 
            // predictionDataToolStripMenuItem
            // 
            this.predictionDataToolStripMenuItem.Checked = true;
            this.predictionDataToolStripMenuItem.CheckOnClick = true;
            this.predictionDataToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.predictionDataToolStripMenuItem.Name = "predictionDataToolStripMenuItem";
            this.predictionDataToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.predictionDataToolStripMenuItem.Text = "Prediction data";
            this.predictionDataToolStripMenuItem.Click += new System.EventHandler(this.PredictionDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // trainerParamsToolStripMenuItem
            // 
            this.trainerParamsToolStripMenuItem.Checked = true;
            this.trainerParamsToolStripMenuItem.CheckOnClick = true;
            this.trainerParamsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trainerParamsToolStripMenuItem.Name = "trainerParamsToolStripMenuItem";
            this.trainerParamsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.trainerParamsToolStripMenuItem.Text = "Trainer params";
            // 
            // loadDatafileDialog
            // 
            this.loadDatafileDialog.Filter = " text files (*.txt, *.csv)|*.txt; *.csv";
            this.loadDatafileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadDatafileDialog_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "binay file|*.bin";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.iterationPerUpdateBox);
            this.gbSettings.Controls.Add(this.label4);
            this.gbSettings.Controls.Add(this.momentumBox);
            this.gbSettings.Controls.Add(this.label6);
            this.gbSettings.Controls.Add(this.alphaBox);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.learningRateBox);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.label8);
            this.gbSettings.Controls.Add(this.iterationsBox);
            this.gbSettings.Controls.Add(this.windowSizeBox);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.label10);
            this.gbSettings.Controls.Add(this.label9);
            this.gbSettings.Controls.Add(this.label5);
            this.gbSettings.Location = new System.Drawing.Point(995, 47);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(195, 202);
            this.gbSettings.TabIndex = 4;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // iterationPerUpdateBox
            // 
            this.iterationPerUpdateBox.Location = new System.Drawing.Point(125, 172);
            this.iterationPerUpdateBox.Name = "iterationPerUpdateBox";
            this.iterationPerUpdateBox.Size = new System.Drawing.Size(60, 20);
            this.iterationPerUpdateBox.TabIndex = 27;
            this.iterationPerUpdateBox.Text = "100";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Iterations/Update:";
            // 
            // momentumBox
            // 
            this.momentumBox.Location = new System.Drawing.Point(125, 45);
            this.momentumBox.Name = "momentumBox";
            this.momentumBox.Size = new System.Drawing.Size(60, 20);
            this.momentumBox.TabIndex = 9;
            this.momentumBox.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Momentum:";
            // 
            // alphaBox
            // 
            this.alphaBox.Location = new System.Drawing.Point(125, 70);
            this.alphaBox.Name = "alphaBox";
            this.alphaBox.Size = new System.Drawing.Size(60, 20);
            this.alphaBox.TabIndex = 11;
            this.alphaBox.Text = "2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sigmoid\'s alpha value:";
            // 
            // learningRateBox
            // 
            this.learningRateBox.Location = new System.Drawing.Point(125, 20);
            this.learningRateBox.Name = "learningRateBox";
            this.learningRateBox.Size = new System.Drawing.Size(60, 20);
            this.learningRateBox.TabIndex = 7;
            this.learningRateBox.Text = "0.1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Learning rate:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(10, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 2);
            this.label8.TabIndex = 22;
            // 
            // iterationsBox
            // 
            this.iterationsBox.Location = new System.Drawing.Point(125, 136);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(60, 20);
            this.iterationsBox.TabIndex = 24;
            this.iterationsBox.Text = "1000";
            // 
            // windowSizeBox
            // 
            this.windowSizeBox.Location = new System.Drawing.Point(125, 105);
            this.windowSizeBox.Name = "windowSizeBox";
            this.windowSizeBox.Size = new System.Drawing.Size(60, 20);
            this.windowSizeBox.TabIndex = 19;
            this.windowSizeBox.Text = "5";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Window size:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 14);
            this.label10.TabIndex = 25;
            this.label10.Text = "( 0 - inifinity )";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Iterations:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 2);
            this.label5.TabIndex = 17;
            // 
            // gbCurrentIteration
            // 
            this.gbCurrentIteration.Controls.Add(this.currentPredictionErrorBox);
            this.gbCurrentIteration.Controls.Add(this.label13);
            this.gbCurrentIteration.Controls.Add(this.currentLearningErrorBox);
            this.gbCurrentIteration.Controls.Add(this.label12);
            this.gbCurrentIteration.Controls.Add(this.currentIterationBox);
            this.gbCurrentIteration.Controls.Add(this.label11);
            this.gbCurrentIteration.Location = new System.Drawing.Point(995, 255);
            this.gbCurrentIteration.Name = "gbCurrentIteration";
            this.gbCurrentIteration.Size = new System.Drawing.Size(195, 100);
            this.gbCurrentIteration.TabIndex = 8;
            this.gbCurrentIteration.TabStop = false;
            this.gbCurrentIteration.Text = "Current iteration:";
            // 
            // currentPredictionErrorBox
            // 
            this.currentPredictionErrorBox.Location = new System.Drawing.Point(125, 70);
            this.currentPredictionErrorBox.Name = "currentPredictionErrorBox";
            this.currentPredictionErrorBox.ReadOnly = true;
            this.currentPredictionErrorBox.Size = new System.Drawing.Size(60, 20);
            this.currentPredictionErrorBox.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(10, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Prediction error:";
            // 
            // currentLearningErrorBox
            // 
            this.currentLearningErrorBox.Location = new System.Drawing.Point(125, 45);
            this.currentLearningErrorBox.Name = "currentLearningErrorBox";
            this.currentLearningErrorBox.ReadOnly = true;
            this.currentLearningErrorBox.Size = new System.Drawing.Size(60, 20);
            this.currentLearningErrorBox.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Learning error:";
            // 
            // currentIterationBox
            // 
            this.currentIterationBox.Location = new System.Drawing.Point(125, 20);
            this.currentIterationBox.Name = "currentIterationBox";
            this.currentIterationBox.ReadOnly = true;
            this.currentIterationBox.Size = new System.Drawing.Size(60, 20);
            this.currentIterationBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(10, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Iteration:";
            // 
            // gbPrediction
            // 
            this.gbPrediction.Controls.Add(this.btnPredict);
            this.gbPrediction.Controls.Add(this.startingPointBox);
            this.gbPrediction.Controls.Add(this.label14);
            this.gbPrediction.Controls.Add(this.predictionSizeBox);
            this.gbPrediction.Controls.Add(this.label15);
            this.gbPrediction.Location = new System.Drawing.Point(995, 361);
            this.gbPrediction.Name = "gbPrediction";
            this.gbPrediction.Size = new System.Drawing.Size(195, 101);
            this.gbPrediction.TabIndex = 9;
            this.gbPrediction.TabStop = false;
            this.gbPrediction.Text = "Prediction";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(114, 72);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 4;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // startingPointBox
            // 
            this.startingPointBox.Location = new System.Drawing.Point(125, 45);
            this.startingPointBox.Name = "startingPointBox";
            this.startingPointBox.Size = new System.Drawing.Size(60, 20);
            this.startingPointBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Starting point:";
            // 
            // predictionSizeBox
            // 
            this.predictionSizeBox.Location = new System.Drawing.Point(125, 20);
            this.predictionSizeBox.Name = "predictionSizeBox";
            this.predictionSizeBox.Size = new System.Drawing.Size(60, 20);
            this.predictionSizeBox.TabIndex = 1;
            this.predictionSizeBox.Text = "1";
            this.predictionSizeBox.TextChanged += new System.EventHandler(this.PredictionSizeBox_TextChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(10, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Prediction size:";
            // 
            // loadNetworkDialog
            // 
            this.loadNetworkDialog.Filter = "bin files (*.bin)|*.bin";
            this.loadNetworkDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadNetworkDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 579);
            this.Controls.Add(this.gbPrediction);
            this.Controls.Add(this.gbCurrentIteration);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Time Series Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbCurrentIteration.ResumeLayout(false);
            this.gbCurrentIteration.PerformLayout();
            this.gbPrediction.ResumeLayout(false);
            this.gbPrediction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNetworkToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog loadDatafileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem trainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleMovingAverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solutionDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trainerParamsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox momentumBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alphaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox learningRateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.TextBox windowSizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCurrentIteration;
        private System.Windows.Forms.TextBox currentPredictionErrorBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox currentLearningErrorBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox currentIterationBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox iterationPerUpdateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPrediction;
        private System.Windows.Forms.TextBox startingPointBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox predictionSizeBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadNetworkToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog loadNetworkDialog;
    }
}

