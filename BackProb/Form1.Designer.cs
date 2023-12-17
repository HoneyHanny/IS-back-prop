namespace BackProb
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
			this.createButton = new System.Windows.Forms.Button();
			this.trainButton = new System.Windows.Forms.Button();
			this.runButton = new System.Windows.Forms.Button();
			this.inputLabel = new System.Windows.Forms.Label();
			this.outputLabel = new System.Windows.Forms.Label();
			this.output = new System.Windows.Forms.Label();
			this.input1 = new System.Windows.Forms.CheckBox();
			this.input2 = new System.Windows.Forms.CheckBox();
			this.input3 = new System.Windows.Forms.CheckBox();
			this.input4 = new System.Windows.Forms.CheckBox();
			this.epoch = new System.Windows.Forms.NumericUpDown();
			this.epochLabel = new System.Windows.Forms.Label();
			this.hiddenNeurons = new System.Windows.Forms.NumericUpDown();
			this.neuronLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.epoch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hiddenNeurons)).BeginInit();
			this.SuspendLayout();
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(50, 94);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(94, 31);
			this.createButton.TabIndex = 0;
			this.createButton.Text = "Create NN";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.CreateButtonOnClick);
			// 
			// trainButton
			// 
			this.trainButton.Enabled = false;
			this.trainButton.Location = new System.Drawing.Point(50, 174);
			this.trainButton.Name = "trainButton";
			this.trainButton.Size = new System.Drawing.Size(94, 31);
			this.trainButton.TabIndex = 0;
			this.trainButton.Text = "Train";
			this.trainButton.UseVisualStyleBackColor = true;
			this.trainButton.Click += new System.EventHandler(this.TrainButtonOnClick);
			// 
			// runButton
			// 
			this.runButton.Enabled = false;
			this.runButton.Location = new System.Drawing.Point(50, 254);
			this.runButton.Name = "runButton";
			this.runButton.Size = new System.Drawing.Size(94, 31);
			this.runButton.TabIndex = 0;
			this.runButton.Text = "Run";
			this.runButton.UseVisualStyleBackColor = true;
			this.runButton.Click += new System.EventHandler(this.RunButtonOnClick);
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.Location = new System.Drawing.Point(296, 47);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(35, 16);
			this.inputLabel.TabIndex = 6;
			this.inputLabel.Text = "Input";
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(506, 47);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(45, 16);
			this.outputLabel.TabIndex = 6;
			this.outputLabel.Text = "Output";
			// 
			// output
			// 
			this.output.AutoSize = true;
			this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.output.Location = new System.Drawing.Point(500, 95);
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(59, 20);
			this.output.TabIndex = 6;
			this.output.Text = "Output";
			// 
			// input1
			// 
			this.input1.AutoSize = true;
			this.input1.Location = new System.Drawing.Point(295, 98);
			this.input1.Name = "input1";
			this.input1.Size = new System.Drawing.Size(36, 20);
			this.input1.TabIndex = 7;
			this.input1.Text = "0";
			this.input1.UseVisualStyleBackColor = true;
			this.input1.CheckedChanged += new System.EventHandler(this.Input1CheckedChanged);
			// 
			// input2
			// 
			this.input2.AutoSize = true;
			this.input2.Location = new System.Drawing.Point(295, 152);
			this.input2.Name = "input2";
			this.input2.Size = new System.Drawing.Size(36, 20);
			this.input2.TabIndex = 7;
			this.input2.Text = "0";
			this.input2.UseVisualStyleBackColor = true;
			this.input2.CheckedChanged += new System.EventHandler(this.Input2CheckedChanged);
			// 
			// input3
			// 
			this.input3.AutoSize = true;
			this.input3.Location = new System.Drawing.Point(295, 206);
			this.input3.Name = "input3";
			this.input3.Size = new System.Drawing.Size(36, 20);
			this.input3.TabIndex = 7;
			this.input3.Text = "0";
			this.input3.UseVisualStyleBackColor = true;
			this.input3.CheckedChanged += new System.EventHandler(this.Input3CheckedChanged);
			// 
			// input4
			// 
			this.input4.AutoSize = true;
			this.input4.Location = new System.Drawing.Point(295, 260);
			this.input4.Name = "input4";
			this.input4.Size = new System.Drawing.Size(36, 20);
			this.input4.TabIndex = 7;
			this.input4.Text = "0";
			this.input4.UseVisualStyleBackColor = true;
			this.input4.CheckedChanged += new System.EventHandler(this.Input4CheckedChanged);
			// 
			// epoch
			// 
			this.epoch.Location = new System.Drawing.Point(473, 283);
			this.epoch.Name = "epoch";
			this.epoch.Size = new System.Drawing.Size(120, 22);
			this.epoch.TabIndex = 8;
			this.epoch.ValueChanged += new System.EventHandler(this.EpochValueChanged);
			// 
			// epochLabel
			// 
			this.epochLabel.AutoSize = true;
			this.epochLabel.Location = new System.Drawing.Point(505, 255);
			this.epochLabel.Name = "epochLabel";
			this.epochLabel.Size = new System.Drawing.Size(46, 16);
			this.epochLabel.TabIndex = 9;
			this.epochLabel.Text = "Epoch";
			// 
			// hiddenNeurons
			// 
			this.hiddenNeurons.Location = new System.Drawing.Point(473, 194);
			this.hiddenNeurons.Name = "hiddenNeurons";
			this.hiddenNeurons.Size = new System.Drawing.Size(120, 22);
			this.hiddenNeurons.TabIndex = 8;
			this.hiddenNeurons.ValueChanged += new System.EventHandler(this.EpochValueChanged);
			// 
			// neuronLabel
			// 
			this.neuronLabel.AutoSize = true;
			this.neuronLabel.Location = new System.Drawing.Point(480, 166);
			this.neuronLabel.Name = "neuronLabel";
			this.neuronLabel.Size = new System.Drawing.Size(105, 16);
			this.neuronLabel.TabIndex = 9;
			this.neuronLabel.Text = "Hidden Neurons";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 350);
			this.Controls.Add(this.neuronLabel);
			this.Controls.Add(this.epochLabel);
			this.Controls.Add(this.hiddenNeurons);
			this.Controls.Add(this.epoch);
			this.Controls.Add(this.input4);
			this.Controls.Add(this.input3);
			this.Controls.Add(this.input2);
			this.Controls.Add(this.input1);
			this.Controls.Add(this.output);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.runButton);
			this.Controls.Add(this.trainButton);
			this.Controls.Add(this.createButton);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Neural Network";
			((System.ComponentModel.ISupportInitialize)(this.epoch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hiddenNeurons)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Button trainButton;
		private System.Windows.Forms.Button runButton;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.Label output;
		private System.Windows.Forms.CheckBox input1;
		private System.Windows.Forms.CheckBox input2;
		private System.Windows.Forms.CheckBox input3;
		private System.Windows.Forms.CheckBox input4;
		private System.Windows.Forms.NumericUpDown epoch;
		private System.Windows.Forms.Label epochLabel;
		private System.Windows.Forms.NumericUpDown hiddenNeurons;
		private System.Windows.Forms.Label neuronLabel;
	}
}

