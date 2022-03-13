using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeSeriesTrainer
{
    public partial class Form1 : Form
    {
        #region Chart variables
        double[] ZoomTimeFrames = new double[] { 5, 15, 30, 60, 240, 1440, 10080, 40320 };
        int numberOfZoom = 8;
        Series TrainingDataSeries;
        Series SolutionDataSeries;
        Series SMADataSeries;
        Series PredictionSeries;
        #endregion

        double[] FileData;
        TimeSeriesTrainer trainer;

        double Max;
        double Min;
        double AdditionalRange = 0;

        int WindowSize = 5;

        private Thread WorkerThread = null;
        bool Running = false;
        bool Paused = false;
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
            trainer = new TimeSeriesTrainer();
        }

        private void SearchSolution()
        {
            //double[][] trainerData = trainer.CreateTrainerData(Normalize(FileData));
            // trainer.AdditionalRange = 50;

           
            int iteration = 0;
            while (Running)
            {
                if (!Paused)
                {
                    double[] solution = trainer.Train();
                    if(iteration % int.Parse(iterationPerUpdateBox.Text) == 0)
                    {
                        UpdateChartSeries(SolutionDataSeries,
                            ArrayToDataPoints(solution, 1, WindowSize));
                    }
                    SetText(currentIterationBox, iteration.ToString());
                    SetText(currentLearningErrorBox, trainer.LearningError.ToString());
                    SetText(currentPredictionErrorBox, trainer.PredictionError.ToString());
                    iteration++;
                }
                
                if (int.Parse(iterationsBox.Text) < iteration)
                {
                    break;
                }
            }

            Running = false;
            ToggleMenuItem(startToolStripMenuItem);
            ToggleMenuItem(pauseToolStripMenuItem);
            ToggleMenuItem(stopToolStripMenuItem);
            ToggleControl(gbSettings);

        }

        public double[] Normalize(double[] x)
        {
            Min = x.Min();
            Max = x.Max();
            double[] result = new double[x.Count()];
            for (int i = 0; i < x.Count(); i++)
            {
                result[i] = ((x[i] - Min) / (1.7/(Max - Min + AdditionalRange)));
            }
            return result;
        }

        public double[] Denormalize(double[] x)
        {
            double[] result = new double[x.Count()];
            for (int i = 0; i < x.Count(); i++)
            {
                result[i] = x[i] * (1.7 * (Max - Min + AdditionalRange)) + Min;
            }
            return result;
        }

        #region Chart functionality
    public void InitializeChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Add("Trainer visualization");
            chart1.Titles[0].Font = new Font("Arial", 14);
            chart1.MouseWheel += Chart1_onMouseScroll;
            chart1.ChartAreas[0].AxisX.ScrollBar.Size = 10;
            chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart1.ChartAreas[0].AxisX.Interval = ZoomTimeFrames[6];
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.00000";

            TrainingDataSeries = chart1.Series.Add("Trainer data");
            TrainingDataSeries.ChartType = SeriesChartType.FastLine;
            TrainingDataSeries.YValueType = ChartValueType.Double;
            TrainingDataSeries.BorderWidth = 3;

            SMADataSeries = chart1.Series.Add("Simple moving average");
            SMADataSeries.ChartType = SeriesChartType.FastLine;
            SMADataSeries.YValueType = ChartValueType.Double;
            SMADataSeries.BorderWidth = 2;

            SolutionDataSeries = chart1.Series.Add("Solution");
            SolutionDataSeries.ChartType = SeriesChartType.FastLine;
            SolutionDataSeries.YValueType = ChartValueType.Double;

            PredictionSeries = chart1.Series.Add("Prediction");
            PredictionSeries.ChartType = SeriesChartType.FastLine;
            PredictionSeries.YValueType = ChartValueType.Double;
        }
        private void Chart1_onMouseScroll(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    if (numberOfZoom < ZoomTimeFrames.Length - 1)
                    {
                        numberOfZoom++;
                        chart1.ChartAreas[0].AxisX.Interval = Math.Ceiling(ZoomTimeFrames[numberOfZoom] / 10);
                        chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, ZoomTimeFrames[numberOfZoom]);
                    }
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    if (numberOfZoom > 0)
                    {
                        numberOfZoom--;
                        chart1.ChartAreas[0].AxisX.Interval = Math.Ceiling(ZoomTimeFrames[numberOfZoom] / 10);
                        chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, ZoomTimeFrames[numberOfZoom]);
                    }
   
                }
                UpdateChartYAxis();
            }
            catch { }
        }
        
        private delegate void UpdateChartCallback(Series series, double[,] xy);
        public void UpdateChartSeries(Series series, double[,] data)
        {
            if (chart1.InvokeRequired)
            {
                UpdateChartCallback d = new UpdateChartCallback(UpdateChartSeries);
                Invoke(d, new object[] { series, data });
            }
            else
            {
                series.Points.Clear();
                for (int i = 0; i < data.Length / 2; i++)
                {
                    series.Points.AddXY(data[i, 0], data[i, 1]);
                }
                UpdateChartYAxis();
            }
        }

        public void UpdateChartYAxis()
        {
            
            int start = (int)chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            int end = (int)chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
            

            // Series ss = chart1.Series.FindByName("SeriesName");
            // use ss instead of chart1.Series[0]

            double[] temp = chart1.Series[0].Points.Where((x, i) => i >= start && i <= end).Select(x => x.YValues[0]).ToArray();
            if (temp.Count() != 0)
            {
                double ymin = temp.Min();
                double ymax = temp.Max();

                chart1.ChartAreas[0].AxisY.Interval = Math.Round((temp.Max() - temp.Min()) / 20, 4);
                chart1.ChartAreas[0].AxisY.ScaleView.Position = ymin;
                chart1.ChartAreas[0].AxisY.ScaleView.Size = ymax - ymin;
            }
        }

        public double[,] ArrayToDataPoints(double[] data, int xInterval, int startingPoint)
        {
            double[,] result = new double[data.Length, 2];
            for(int i = 0; i < data.Length; i++)
            {
                result[i, 0] = startingPoint + i * xInterval;
                result[i, 1] = data[i];
            }
            return result;
        }
        #endregion

        #region Menubar functionality

        private void LoadNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadNetworkDialog.ShowDialog();
        }
        private void LoadNetworkDialog_FileOk(object sender, CancelEventArgs e)
        {

            trainer.LoadNetwork(loadNetworkDialog.FileName);
            currentLearningErrorBox.Text = "";
            currentPredictionErrorBox.Text = "";
            currentIterationBox.Text = ""; 
            
        }
        private void LoadDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDatafileDialog.ShowDialog();
        }

        private void LoadDatafileDialog_FileOk(object sender, CancelEventArgs e)
        {
            foreach(Series serie in chart1.Series)
            {
                serie.Points.Clear();
            }
            FileData = trainer.LoadDataFromFile(loadDatafileDialog.FileName);
            startingPointBox.Text = (FileData.Length - 1).ToString();

            Max = FileData.Max();
            Min = FileData.Min();
            UpdateChartSeries(TrainingDataSeries,
                    ArrayToDataPoints(FileData, 1, 0));

            UpdateChartSeries(SMADataSeries,
                ArrayToDataPoints(
                    trainer.GetSimpleMovingAverage(FileData, 24),
                    24, 12));

            UpdateChartYAxis();
            startToolStripMenuItem.Enabled = true;

            trainer.PrepareData(FileData);
        }

        private void SaveNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trainer.NeuralNetwork != null)
            {
                saveFileDialog1.FileName = "Time_series_solution_" + DateTimeToFileName(DateTime.Now);
                saveFileDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no network to save.");
            }
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
              trainer.SaveNetwork(saveFileDialog1.FileName);
        }

        public string DateTimeToFileName(DateTime dateTime)
        {
            return dateTime.Year.ToString() + "_" + dateTime.Month.ToString() + "_" + dateTime.Day.ToString() + "_" + dateTime.Hour + dateTime.Minute;
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            pauseToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = true;
            gbSettings.Enabled = false;

            Running = true;

            trainer.LearningRate = double.Parse(learningRateBox.Text);
            trainer.Momentum = double.Parse(momentumBox.Text);
            trainer.SigmoidAlphaValue = int.Parse(alphaBox.Text);
            if(trainer.NeuralNetwork == null)
            {
                trainer.WindowSize = int.Parse(windowSizeBox.Text);
                WindowSize = int.Parse(windowSizeBox.Text);
            }
            else
            {
                windowSizeBox.Text = trainer.WindowSize.ToString();
            }

            WorkerThread = new Thread(new ThreadStart(SearchSolution));
            WorkerThread.Start();
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Paused) {
                pauseToolStripMenuItem.Text = "Pause";
            }
            else
            {
                pauseToolStripMenuItem.Text = "Resume";
            }
            
            Paused = !Paused;
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Running = false;
            while (!WorkerThread.Join(100))
                Application.DoEvents();
            WorkerThread = null;
            startToolStripMenuItem.Enabled = true;
            pauseToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            gbSettings.Enabled = true;
        }

        private void TrainerDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrainingDataSeries.Enabled = !TrainingDataSeries.Enabled;
        }

        private void SimpleMovingAverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SMADataSeries.Enabled = !SMADataSeries.Enabled;
        }

        private void SolutionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolutionDataSeries.Enabled = !SolutionDataSeries.Enabled;
        }

        private void PredictionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredictionSeries.Enabled = !PredictionSeries.Enabled;
        }
        #endregion
        private delegate void ToggleMenuItemCallback(ToolStripMenuItem menuItem);

        public void ToggleMenuItem(ToolStripMenuItem menuItem)
        {
            if (chart1.InvokeRequired)
            {
                ToggleMenuItemCallback d = new ToggleMenuItemCallback(ToggleMenuItem);
                Invoke(d, new object[] { menuItem });
            }
            else
            {
                menuItem.Enabled = !menuItem.Enabled;
            }
        }

        private delegate void ToggleControlCallback(Control control);

        public void ToggleControl(Control control)
        {
            if (chart1.InvokeRequired)
            {
                ToggleControlCallback d = new ToggleControlCallback(ToggleControl);
                Invoke(d, new object[] { control });
            }
            else
            {
                control.Enabled = !control.Enabled;
            }
        }

        private delegate void SetTextCallback(Control control, string text);

        public void SetText(Control control, string text)
        {
            if (chart1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PredictionSizeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            int startingPoint = int.Parse(startingPointBox.Text);
            if (startingPoint > FileData.Length - 1) startingPoint = FileData.Length - 1;
            double[] input = new double[WindowSize];
            for (int i = 0; i < WindowSize; i++)
            {
                input[i] = FileData[startingPoint - WindowSize + i];
            }
            double[] result = trainer.Predict(input, int.Parse(predictionSizeBox.Text));

            UpdateChartSeries(PredictionSeries, ArrayToDataPoints(result, 1, startingPoint));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(WorkerThread != null) WorkerThread.Abort();

        }

        private void Chart1_AxisViewChanged(object sender, ViewEventArgs e)
        {
            if (e.Axis.AxisName == AxisName.X)
            {
                UpdateChartYAxis();
            }
        }
    }
}
