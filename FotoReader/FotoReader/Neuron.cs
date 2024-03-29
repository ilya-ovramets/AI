﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoReader
{
    class Neuron
    {
        public List<double> Weights { get;}

        public NeyronType NeuronType { get;}

        public double Output { get; private set; }

        public Neuron(int inputCount, NeyronType type = NeyronType.Normal)
        {
            NeuronType = type;
            Weights = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }

        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }

            Output = Sigmoid(sum);

            return Output;
        }

        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Pow(Math.E, -x));

            return result;
        }

        public override string ToString()
        {
            return Output.ToString();
        }


    }
}
