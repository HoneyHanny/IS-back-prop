using Backprop;
using System;
using System.Windows.Forms;

namespace BackProb
{
	public partial class Form1 : Form
	{

		private NeuralNet _nn;
		private int _epochs;

		public Form1()
		{
			InitializeComponent();
			epoch.Maximum = decimal.MaxValue;
			hiddenNeurons.Maximum = decimal.MaxValue;
		}

		private void CreateButtonOnClick(object sender, EventArgs e)
		{
			_nn = new NeuralNet(4, (int)hiddenNeurons.Value, 1);

			trainButton.Enabled = true;
			runButton.Enabled = true;
		}

		private void TrainButtonOnClick(object sender, EventArgs e)
		{
			const int inputCount = 4;
			const int expectedOutputCount = 16;
			double[] inputs = new double[inputCount];
			double[] expectedOutputs = new double[expectedOutputCount];

			for (int i = 0; i < _epochs; i++)
			{
				for (int j = 0; j < expectedOutputCount; j++)
				{
					inputs[0] = (j & 1) > 0 ? 1.0 : 0.0;
					inputs[1] = (j & 2) > 0 ? 1.0 : 0.0;
					inputs[2] = (j & 4) > 0 ? 1.0 : 0.0;
					inputs[3] = (j & 8) > 0 ? 1.0 : 0.0;

					expectedOutputs[j] = j == 15 ? 1.0 : 0.0;

					for (int k = 0; k < inputs.Length; k++)
						_nn.SetInput(k, inputs[k]);

					_nn.SetDesiredOutput(0, expectedOutputs[j]);
					_nn.Learn();
				}
			}
		}

		private void RunButtonOnClick(object sender, EventArgs e)
		{
			double input1 = Convert.ToDouble(this.input1.Text);
			double input2 = Convert.ToDouble(this.input2.Text);
			double input3 = Convert.ToDouble(this.input3.Text);
			double input4 = Convert.ToDouble(this.input4.Text);

			_nn.SetInput(0, input1);
			_nn.SetInput(1, input2);
			_nn.SetInput(2, input3);
			_nn.SetInput(3, input4);

			_nn.Run();

			output.Text = _nn.GetOutputData(0).ToString("0.000000");
		}

		private void CheckBoxCheckedChanged(CheckBox rb)
		{
			if (rb.Checked)
				rb.Text = "1";
			else
				rb.Text = "0";
		}

		private void Input1CheckedChanged(object sender, EventArgs e)
		{
			CheckBoxCheckedChanged(input1);
		}

		private void Input2CheckedChanged(object sender, EventArgs e)
		{
			CheckBoxCheckedChanged(input2);
		}

		private void Input3CheckedChanged(object sender, EventArgs e)
		{
			CheckBoxCheckedChanged(input3);
		}

		private void Input4CheckedChanged(object sender, EventArgs e)
		{
			CheckBoxCheckedChanged(input4);
		}

		private void EpochValueChanged(object sender, EventArgs e)
		{
			_epochs = (int)epoch.Value;
		}
	}
}
