using System;

namespace Backprop
{
	public class INeuron
	{
		private int _idno;
		private double _input;
		private double [] _weights; // 64 2 neurons to be connected
		private int _wsize;
		private int _num;
		static Random _rand;
		public INeuron()
		{
			_idno = 0;
			_input = 0;
			_wsize = 64;
			_weights = new double[_wsize];
			SetRandomWeights(_wsize);
		}
		public INeuron(int idnodata, int size)
		{
			_idno = idnodata;
			_input = 0;
			_wsize = size;
			_weights = new double[_wsize];
			SetRandomWeights(_wsize);
		}
		private double Randomweight()
		{
			/*DateTime x = DateTime.Now;
			Random rnd = new Random((int)x.Millisecond);
			num += (int)(rnd.Next()%100.00);
			return 2*((float)(num/100.00));
			
			Random y = new Random();
			double x = (double)y.Next(-10,10);
			Console.WriteLine("at hidden {0} = {1}", this.idno,x);
			return x;*/
			
			if(_rand == null)
			{
				_rand = new System.Random();
			}
                
			int MaxLimit = + 1000; 
                
			int MinLimit = - 1000; 

			double number = (double) (_rand.Next(MinLimit,MaxLimit))/2000;
                
			return number; 
		}
		public void SetRandomWeights(int size)
		{
			for(int x = 0; x < size; x++)
			{
				_weights[x] = Randomweight();
			}		
		
		}
		public void SetWeight(int hidno, double err, double lrpin)
		{
			double errlrpin = err * lrpin;
			_weights[hidno] += (errlrpin*_input);
		}
		
		public void SetID(int no)
		{
			_idno = no;
		}
		public void SetInput(double data)
		{
			_input = data;
		}
		public double GetInput()
		{
			return _input;
		}
		public double GetWeight(int hidno)
		{
			return _weights[hidno];
		}
		public int GetID()
		{
			return _idno;
		}
		public void SetWeight(int pos,double dat)
		{
			_weights[pos] = dat;
		}
	}// end of class INEURON
}
