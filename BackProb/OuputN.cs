using System;

namespace Backprop
{
	public class ONeuron
	{
		private double _bias;
		private int _idno;
		private double _OActivation;
		static Random _rand;
		public ONeuron()
		{
			_bias = RandomBias();
			_idno = 0;
			_OActivation = 0.0;
		}
		public ONeuron(int idnodata)
		{
			_bias = 0.01; //RandomBias();
			_idno = idnodata;
			_OActivation = 0.0;
		}

		public void SetIdno(int data)
		{
			_idno = data;
		}
		public int GetIdno()
		{
			return _idno;
		}
		public void setOActivation(double data)
		{
			_OActivation = data;
		}
		public double GetOActivation()
		{
			return _OActivation;
		}
		public double GetBias()
		{
			return _bias;
		}
		public void SetBias(double dat)
		{
			_bias = dat;
		}
		public void ChangeBias(double lrpout, double []der)
		{
			_bias += lrpout * der[_idno];
		}
		private double RandomBias()
		{
		/*	int num;
			
			DateTime x = DateTime.Now;
			Random rnd = new Random((int)x.Millisecond);
			num = (int)(rnd.Next() % 100.00);
			return 2*((float)(num / 100.00));
			Random y = new Random();
			double x = (double)y.Next(-10,10);
			Console.WriteLine("at hidden {0} = {1}", this.idno,x);
			return x;*/
			if(_rand == null)
			{
				_rand = new System.Random();
			}
                
			int MaxLimit = +1000; 
                
			int MinLimit = -1000; 

			double number = (double) (_rand.Next(MinLimit, MaxLimit)) / 2000;
                
			return number; 
			
		}
	}//end of class ONeuron

}
