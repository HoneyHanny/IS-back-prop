using System;
using System.IO;

namespace Backprop
{
	public class NeuralNet
	{
		private INeuron [] _ineuron; // approximatelty 3072
		private HNeuron [] _hneuron; // approx 64
		private ONeuron [] _oneuron; // approx 10
		private const double LRPOUT = 0.2; // learning rate for the the ouptput layer
		private const double LRPIN = 0.15; // learning rate for the input layer
		private double [] _errorComponent; // approx 10;
		private double [] _errorDerivative;
		private double [] _desiredout;

		public NeuralNet()
		{
			_ineuron = new INeuron[3072];
			_hneuron = new HNeuron[64];
			_oneuron = new ONeuron[10];
			_desiredout = new double[10];
			_errorComponent = new double[10];
			_errorDerivative = new double[10];
			CreateNeurons(_ineuron.Length, _hneuron.Length, _oneuron.Length);
		}
		public NeuralNet(int input, int hidden, int output)
		{
			_ineuron = new INeuron[input];
			_hneuron = new HNeuron[hidden];
			_oneuron = new ONeuron[output];
			_errorComponent = new double[output];
			_errorDerivative = new double[output];
			_desiredout = new double[output];
			CreateNeurons(_ineuron.Length, _hneuron.Length, _oneuron.Length);
		}
		public void CreateNeurons(int i, int h, int o)
		{
			for (int x = 0; x < i; x++)
			{
				_ineuron[x] = new INeuron(x, h);
			}
			for (int x = 0; x < h; x++)
			{
				_hneuron[x] = new HNeuron(x, o);
			}
			for (int x = 0; x < o; x++)
			{
				_oneuron[x] = new ONeuron(x);
			}

		}
		public double GetOutputData(int pos)
		{
			return _oneuron[pos].GetOActivation();
		}
		public void SetInput(int pos, double data)
		{
			_ineuron[pos].SetInput(data);
		}
		public void SetDesiredOutput(int pos, double data)
		{
			_desiredout[pos] = data;
		}
		public double Sigmoid(double dat)
		{
			if (dat >= 20.00)
			{
				dat = 32;
			}
			return (double)(1.0 / (1.0 + System.Math.Exp(-dat)));
		}
		public void CalculateHA()
		{
			// calculate the diferent activations on the 2 neurons
			for (int x = 0; x < _hneuron.Length; x++)
			{
				double summation = 0.0;
				for (int y = 0; y < _ineuron.Length; y++)
				{
					summation += _ineuron[y].GetInput() * _ineuron[y].GetWeight(x);
				}
				_hneuron[x].SetHactivation(Sigmoid(summation+_hneuron[x].GetBias()));
				//hneuron[x].setHactivation(sigmoid(summation));
			}
		}
		public void CalculateOA()
		{
			// calculate the differnent activations for the output layers
			for (int x = 0; x < _oneuron.Length; x++)
			{
				double summation = 0.0;
				for (int y = 0; y < _hneuron.Length; y++)
				{
					summation += _hneuron[y].GetHactivation() * _hneuron[y].GetWeight(x);
				}
				_oneuron[x].setOActivation(Sigmoid(summation+_oneuron[x].GetBias()));
				//oneuron[x].setOActivation(sigmoid(summation));
			}
		}
		public void CalculateEC()
		{
			//calculate the different EC on the the output layer
			for (int x = 0; x < _oneuron.Length; x++)
			{
				_errorComponent[x] = (_desiredout[x]) - (_oneuron[x].GetOActivation());
			}
		}
		public void CalculateDER()
		{
			//calclulate the different derivatives on the output layer
			for (int x = 0; x < _oneuron.Length; x++)
			{
				_errorDerivative[x] = _oneuron[x].GetOActivation() * (1-(_oneuron[x].GetOActivation())) * _errorComponent[x];
			}
		}
		public void Learn()
		{
			// trainning session
			Run();
			CalculateEC();
			CalculateDER();
			for (int x = 0; x < _hneuron.Length; x++) //calculates the errors of every neuron in the 2 layer
				_hneuron[x].CalculateErr(_errorDerivative);
			for (int x = 0; x < _hneuron.Length; x++) //change in the weights in the 2 to ouput
				_hneuron[x].SetWeight(LRPOUT, _errorDerivative);
			for (int x = 0; x < _ineuron.Length; x++) //change the weights in the input to 2
			{
				for (int y = 0; y < _hneuron.Length; y++)
				{
					_ineuron[x].SetWeight(y, _hneuron[y].GetErr(), LRPIN);
				
				}
			}
			for (int x = 0; x < _oneuron.Length; x++) //change in output neuron bias
				_oneuron[x].ChangeBias(LRPOUT, _errorDerivative);
			for (int x = 0; x < _hneuron.Length; x++) //change in 2 neuron bias
				_hneuron[x].ChangeBias(LRPIN);

		}
		public void Run()
		{
			CalculateHA();
			CalculateOA();
			//application phase
		}
		public bool CountGood()
		{
			// session terminator
			bool result = true;
			for (int x = 0; x < _oneuron.Length; x++)
			{
				if ((_errorComponent[x] - _errorDerivative[x]) != 0)
					result = false;
			}
			return result;
		}
		public void SaveWeights(String path)
		{

			using (StreamWriter sw = new StreamWriter(path)) 
			{
				for (int x = 0; x < _ineuron.Length; x++)//saving the weights of the input layer
				{
					for (int y = 0; y < _hneuron.Length; y++)
					sw.WriteLine(_ineuron[x].GetWeight(y));
				}
				for (int x = 0; x < _hneuron.Length; x++)//saving the wieghts of the hidden layer
				{
					for (int y = 0; y < _oneuron.Length; y++)
					{
						sw.WriteLine(_hneuron[x].GetWeight(y));
					}
				}
				for (int x = 0; x < _hneuron.Length; x++)// saving hidden layer bias
				{
					sw.WriteLine(_hneuron[x].GetBias());
				}
				for (int x = 0; x < _oneuron.Length; x++)// saving output layer bias
				{
					sw.WriteLine(_oneuron[x].GetBias());
				}
			}// end of streamwriter
		}

		public void LoadWeights(String path) //load data 
		{
			using (StreamReader sr = new StreamReader(path)) 
			{
				for (int x = 0; x < _ineuron.Length; x++) //loading the weights of the input layer
				{
					for (int y = 0; y < _hneuron.Length; y++)
					{
						_ineuron[x].SetWeight(y, Convert.ToDouble(sr.ReadLine()));
					}
				}
				for (int x = 0; x < _hneuron.Length; x++) //loading the wieghts of the hidden layer
				{
					for (int y = 0; y < _oneuron.Length; y++)
					{
						_hneuron[x].SetWeight(y,Convert.ToDouble(sr.ReadLine()));
					}
				}
				for (int x = 0; x < _hneuron.Length; x++) // loading hidden layer bias
				{
					_hneuron[x].SetBias(Convert.ToDouble(sr.ReadLine()));
				}
				for (int x = 0; x < _oneuron.Length; x++) // loading output layer bias
				{
					_oneuron[x].SetBias(Convert.ToDouble(sr.ReadLine()));
				}
			}//end of streamreader
		}
	}//end of neural net
}
