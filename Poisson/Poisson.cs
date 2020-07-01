using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Distributions;

namespace Poisson
{
    class Poisson
    {
        static readonly Random random = new Random();
        public Poisson(double tV, int nV, double l1, double l2)
        {
            t = tV;
            N = nV;
            ALambda = l1 + l2;
            AStream = new AggregatedStream(l1, l2);
        }
        double t { get; set; }
        int N { get; set; }
        double ALambda { get; set; }
        AggregatedStream AStream { get; set; }

        public double Average { get; private set; }
        public double AverageError { get; private set; }
        public double Variance { get; private set; }
        public double VarianceError { get; private set; }

        public double Chi { get; private set; }
        public bool ChiTest { get; private set; }
        public double CriticalValue { get; private set; }

        public double[] possbilities { get; private set; }
        public double[] teorPossibs { get; private set; }

        class Stream
        {
            public Stream(double lambda)
            {
                Lambda = lambda;

                frequency = new Dictionary<int, int>();
            }

            double Lambda { get; set; }
            IDictionary<int, int> frequency { get; set; }
            public int Process(double t)
            {
                double a = 0;
                int n = 0;
                while(true)
                {
                    a += -Math.Log(random.NextDouble()) / Lambda;

                    if (a > t) break;

                    n++;
                }
                if (!frequency.ContainsKey(n))
                {
                    frequency[n] = 0;
                }
                frequency[n]++;
                return n;
            }
        }

        class AggregatedStream
        {
            public AggregatedStream(double lambda1, double lambda2)
            {
                Stream1 = new Stream(lambda1);
                Stream2 = new Stream(lambda2);

                frequency = new Dictionary<int, int>();
            }
            Stream Stream1 { get; set; }
            Stream Stream2 { get; set; }
            IDictionary<int, int> frequency { get; set; }
            public void Process(double t)
            {
                var n1 = Stream1.Process(t);
                var n2 = Stream2.Process(t);

                if (!frequency.ContainsKey(n1 + n2)) frequency[n1 + n2] = 0;
                frequency[n1 + n2]++;
            }

            public double[] GetFrequency()
            {
                double[] res = new double[frequency.Last().Key+1];
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = frequency.ContainsKey(i) ? frequency[i] : 0;
                }

                return res;
            }
        }
        public void Start()
        {
            for (int i = 0; i < N; i++)
            {
                AStream.Process(t);
            }
            var frequency = AStream.GetFrequency();
            possbilities = EmpiricalProbs(frequency, N);
            teorPossibs = TheoreticalProbs(ALambda, t, possbilities.Length);
            Average = 0;
            double E = 0;
            for (int i = 0; i < possbilities.Length; i++)
            {
                Average += possbilities[i] * i;
                E += teorPossibs[i] * i;
            }
            AverageError = Math.Abs((Average - E) / E);
            Variance = 0;
            double D = 0;
            for (int i = 0; i < possbilities.Length; i++)
            {
                Variance += possbilities[i] * i * i;
                D += teorPossibs[i] * i * i;
            }
            Variance -= Average * Average;
            D -= E * E;
            VarianceError = Math.Abs((Variance - D) / D);
            Chi = 0;
            for (int i = 0; i < possbilities.Length; i++)
            {
                Chi += (frequency[i] - N * teorPossibs[i]) * (frequency[i] - N * teorPossibs[i]) / (N * teorPossibs[i]);
            }

            if (possbilities.Length > 1)
            {
                CriticalValue = ChiSquared.InvCDF(possbilities.Length - 1, 0.95);
                if (Chi <= CriticalValue)
                {
                    ChiTest = true;
                }
                else
                {
                    ChiTest = false;
                }
            }
        }
        private double[] EmpiricalProbs(double[] frequency, int N)
        {
            double[] probs = new double[frequency.Length];
            for (int i = 0; i < probs.Length; i++)
            {
                probs[i] = frequency[i] / N;
            }
            return probs;
        }

        private double[] TheoreticalProbs(double lambda, double T, int n)
        {
            double[] probs = new double[n];
            for (int i = 0; i < n; i++)
            {
                probs[i] = Math.Pow(lambda * T, i) / Factorial(i) * Math.Exp(-lambda*T);
            }
            return probs;
        }
        static int Factorial(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else 
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
