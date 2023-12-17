using System;

namespace Backprop
{
	public class HNeuron
	{
		private double []_weights;//there will be 10 for the input neurons
		private int _idno;
		private int _wsize;
		private double _hactivation;
		private double _bias;
		private double _error;
		static Random _rand;
		public HNeuron()
		{
			_idno = 0;
			_hactivation = 0.0;
			_bias = Randomweight();
			_error = 0.0;
			_wsize = 10;
			_weights = new double[10];
			SetRandomWeights(10);
		}
		public HNeuron(int idnodata, int size)
		{
			_idno = idnodata;
			_hactivation = 0.0;
			_bias = 0.01; //Randomweight();
			_wsize = size;
			_error = 0.0;
			_weights = new double[_wsize];
			SetRandomWeights(_wsize);
		}
		public void CalculateErr(double [] der)
		{
			// calculate the error on the input layer
			double result = 0.0;
			for (int x = 0; x < der.Length; x++)
			{
				result += (der[x] * _weights[x]);
			}
			//result*=hactivation;
			//result*=(1-hactivation);
			_error = (result * _hactivation * (1 - _hactivation));
		}
		public void SetWeight(double lrpout, double [] der)
		{
			// change the weights of connected between input and 2 layer
			double temp = 0.0;
			temp = _hactivation * lrpout;
			for (int x = 0; x < der.Length; x++)
			{
				_weights[x] += (temp * der[x]);
			}
		}
		public void SetWeight(int pos, double dat)
		{
			_weights[pos] = dat;
		}
		public double GetWeight(int outid)
		{
			return _weights[outid];
		}
		public void SetErr(double x)
		{
			_error = x;
		}
		public double GetErr()
		{
			return _error;
		}
		public void SetHactivation(double data)
		{
			_hactivation = data;
		}
		public double GetHactivation()
		{
			return _hactivation;
		}
		public void SetIdno(int x)
		{
			_idno = x;
		}
		public int GetIdno()
		{
			return _idno;
		}
		public void SetBias(double b)
		{
			_bias = b;
		}
		public double GetBias()
		{
			return _bias;
		}
		public void ChangeBias(double lrpin)
		{
			//change the bias of this neuron
			_bias += (_error * lrpin);
		}
		public void SetRandomWeights(int size)
		{
			for (int x = 0; x < size; x++)
			{
				_weights[x] = Randomweight();
			}
		}
		private double Randomweight()
		{
			/*int num;
			DateTime x = DateTime.Now;
			Random rnd = new Random((int)x.Millisecond);
			num= (int)(rnd.Next() % 100.00);
			return 2 * ((float)(num / 100.00));
			
			Random y = new Random();
			double x = (double) y.Next(-10, 10);
			Console.WriteLine("at hidden {0} = {1}", this.idno, x);
			return x;*/
			if (_rand == null)
			{
				_rand = new System.Random();
			}
                
			int MaxLimit = + 1000; 
                
			int MinLimit = - 1000; 

			double number = (double) (_rand.Next(MinLimit, MaxLimit)) / 2000;
                
			return number; 
		}
	}//end of class HNeuron
}
