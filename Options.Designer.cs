namespace KotMineSweeper
{
	partial class Options
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
			difficulty = new GroupBox();
			radioBtnBeginner = new RadioButton();
			radioBtnIntermediate = new RadioButton();
			radioBtnAdvanced = new RadioButton();
			btnOptionsOK = new Button();
			btnOptionsCancel = new Button();
			difficulty.SuspendLayout();
			SuspendLayout();
			// 
			// difficulty
			// 
			difficulty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			difficulty.Controls.Add(radioBtnAdvanced);
			difficulty.Controls.Add(radioBtnIntermediate);
			difficulty.Controls.Add(radioBtnBeginner);
			difficulty.Location = new Point(12, 12);
			difficulty.Name = "difficulty";
			difficulty.Size = new Size(514, 231);
			difficulty.TabIndex = 0;
			difficulty.TabStop = false;
			difficulty.Text = "Difficulty";
			difficulty.Enter += groupBox1_Enter;
			// 
			// radioBtnBeginner
			// 
			radioBtnBeginner.AutoSize = true;
			radioBtnBeginner.Location = new Point(6, 38);
			radioBtnBeginner.Name = "radioBtnBeginner";
			radioBtnBeginner.Size = new Size(72, 19);
			radioBtnBeginner.TabIndex = 0;
			radioBtnBeginner.TabStop = true;
			radioBtnBeginner.Text = "Beginner";
			radioBtnBeginner.UseVisualStyleBackColor = true;
			radioBtnBeginner.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// radioBtnIntermediate
			// 
			radioBtnIntermediate.AutoSize = true;
			radioBtnIntermediate.Location = new Point(6, 63);
			radioBtnIntermediate.Name = "radioBtnIntermediate";
			radioBtnIntermediate.Size = new Size(92, 19);
			radioBtnIntermediate.TabIndex = 1;
			radioBtnIntermediate.TabStop = true;
			radioBtnIntermediate.Text = "Intermediate";
			radioBtnIntermediate.UseVisualStyleBackColor = true;
			radioBtnIntermediate.CheckedChanged += radioButton1_CheckedChanged_1;
			// 
			// radioBtnAdvanced
			// 
			radioBtnAdvanced.AutoSize = true;
			radioBtnAdvanced.Location = new Point(6, 88);
			radioBtnAdvanced.Name = "radioBtnAdvanced";
			radioBtnAdvanced.Size = new Size(78, 19);
			radioBtnAdvanced.TabIndex = 2;
			radioBtnAdvanced.TabStop = true;
			radioBtnAdvanced.Text = "Advanced";
			radioBtnAdvanced.UseVisualStyleBackColor = true;
			// 
			// btnOptionsOK
			// 
			btnOptionsOK.Location = new Point(370, 459);
			btnOptionsOK.Name = "btnOptionsOK";
			btnOptionsOK.Size = new Size(75, 23);
			btnOptionsOK.TabIndex = 1;
			btnOptionsOK.Text = "OK";
			btnOptionsOK.UseVisualStyleBackColor = true;
			btnOptionsOK.Click += button1_Click;
			// 
			// btnOptionsCancel
			// 
			btnOptionsCancel.Location = new Point(451, 459);
			btnOptionsCancel.Name = "btnOptionsCancel";
			btnOptionsCancel.Size = new Size(75, 23);
			btnOptionsCancel.TabIndex = 2;
			btnOptionsCancel.Text = "Cancel";
			btnOptionsCancel.UseVisualStyleBackColor = true;
			// 
			// Options
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(546, 494);
			Controls.Add(btnOptionsCancel);
			Controls.Add(btnOptionsOK);
			Controls.Add(difficulty);
			Name = "Options";
			Text = "Options";
			difficulty.ResumeLayout(false);
			difficulty.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox difficulty;
		private RadioButton radioBtnBeginner;
		private RadioButton radioBtnIntermediate;
		private RadioButton radioBtnAdvanced;
		private Button btnOptionsOK;
		private Button btnOptionsCancel;
	}
}