using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AForge.Neuro;
using AForge.Neuro.Learning;

namespace TimeSeriesTrainer
{
    class TimeSeriesTrainer
    {
        public int WindowSize = 5;
        public int PredictionSize = 1;
        public int SigmoidAlphaValue = 2;
        public double LearningRate = 0.001;
        public double Momentum = 0.10;
        public double AdditionalRange = 0;
        public ActivationNetwork NeuralNetwork;
        public double Error { get; private set; }
        public double PredictionError { get; private set; }
        public double LearningError { get; private set; }
        public double[] Solution { get; private set; }
        public double[] Data { get; private set; }
        public double[][] Input { get; private set; }
        public double[][] Output { get; private set; }
        public int Samples { get; private set; }

        double Mean;
        double StandardDeviation;

        double Factor;
        double YMin;



        public TimeSeriesTrainer()
        {

        }


        public void PrepareData(double[] data)
        {
            Data = data;
            Mean = GetMean(data);
            StandardDeviation = GetStandardDeviation(data, Mean);
            Samples = Data.Length - PredictionSize - WindowSize;

            //Create input and output
            double[][] input = new double[Samples][];
            double[][] output = new double[Samples][];

            for (int i = 0; i < Samples; i++)
            {
                input[i] = new double[WindowSize];
                output[i] = new double[1];

                // set input
                for (int j = 0; j < WindowSize; j++)
                {
                    input[i][j] = Standardize(Data[i + j], Mean, StandardDeviation);
                }
                // set output
                output[i][0] = Standardize(Data[i + WindowSize], Mean, StandardDeviation);
            }

            Input = input;
            Output = output;
        }

        public double[] Train()
        {
            if (Data == null) return null;

            Factor = 1.7 / (Data.Max() - Data.Min());
            YMin = Data.Min();

            if (NeuralNetwork == null)
            {
                NeuralNetwork = new ActivationNetwork(
                   new BipolarSigmoidFunction(SigmoidAlphaValue),
                   WindowSize, WindowSize * 2, 1);
            }

            BackPropagationLearning teacher = new BackPropagationLearning(NeuralNetwork);

            teacher.LearningRate = LearningRate;
            teacher.Momentum = Momentum;

            double Error = teacher.RunEpoch(Input, Output) / Samples;

            double[] networkInput = new double[WindowSize];
            double[] solution = new double[Data.Length - WindowSize];
            double[] derp = new double[Data.Length - WindowSize];
            double predictionError = 0;
            double learningError = 0;
            for (int i = 0, n = Data.Length - WindowSize; i < n; i++)
            {
                // put values from current window as network's input
                for (int j = 0; j < WindowSize; j++)
                {
                    networkInput[j] = Standardize(Data[i + j], Mean, StandardDeviation);
                }

                // evalue the function
                derp[i] = NeuralNetwork.Compute(networkInput)[0];
                solution[i] = InverseStandardize(NeuralNetwork.Compute(networkInput)[0], Mean, StandardDeviation);

                // calculate prediction error
                if (i >= n - PredictionSize)
                {
                    predictionError += Math.Abs(solution[i] - Data[WindowSize + i]);
                }
                else
                {
                    learningError += Math.Abs(solution[i] - Data[WindowSize + i]);
                }
            }
            PredictionError = predictionError;
            LearningError = learningError;
            return solution;
        }
 
        public double[] GetSimpleMovingAverage(double[] data, int interval)
        {
            int count = data.Count() / interval;
            double[] result = new double[count];

            for (int i = 0; i < count; i++)
            {
                double sum = 0;
                for (int j = 0; j < interval; j++)
                {
                    sum += data[i * interval + j];
                }
                result[i] = sum / interval;
            }
            return result;
        }

        public double[] Predict(double[] input, int predictionSize)
        {
            if (NeuralNetwork == null) return null;
            double[] result = new double[predictionSize];
            double[] dataWithFutureData = Data;
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Standardize(input[i], Mean, StandardDeviation);
            }

            for (int i = 0; i < predictionSize; i++)
            {

                double mean = GetMean(dataWithFutureData);
                double standardDeviation = GetStandardDeviation(dataWithFutureData, mean);
                result[i] = InverseStandardize(NeuralNetwork.Compute(input)[0], mean, standardDeviation);
                dataWithFutureData.Append(result[i]);

                for (int j = 0; j < input.Count() - 1; j++)
                {
                    input[j] = input[j + 1];
                }


                input[input.Count() - 1] = Standardize(result[i], mean, standardDeviation);
            }
            return result;
        }

        public double[] LoadDataFromFile(string fileName)
        {
            using (var reader = new StreamReader(@fileName))
            {
                List<double> data = new List<double>();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    data.Add(double.Parse(line));
                }
                return data.ToArray();
            }
        }

        public ActivationNetwork LoadNetwork(string fileName)
        {
            NeuralNetwork = (ActivationNetwork)Network.Load(fileName);
            WindowSize = NeuralNetwork.InputsCount;
            return NeuralNetwork;
        }


        public void SaveNetwork(string fileName)
        {
            if(NeuralNetwork != null)
            {
                NeuralNetwork.Save(fileName);
            }
        }


        private double GetStandardDeviation(double[] data, double mean)
        {
            int length = data.Length;
            double sq_diff_sum = 0;
            for (int i = 0; i < length; ++i)
            {
                double diff = data[i] - mean;
                sq_diff_sum += diff * diff;
            }
            double variance = sq_diff_sum / length;

            return Math.Sqrt(variance);
        }

        private double GetMean(double[] data)
        {
            return data.Sum() / data.Length;
        }

        public double Standardize(double dataPoint, double mean, double standardDeviation)
        {
            return dataPoint;
            //return (dataPoint - mean) / 1.96;
        }
        public double InverseStandardize(double dataPoint, double mean, double standardDeviation)
        {
            return dataPoint;
            //return dataPoint * 1.96 + mean;
        }
       
    }
}
