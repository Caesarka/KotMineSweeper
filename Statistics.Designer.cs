namespace KotMineSweeper
{
	partial class Statistics
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
			listBox1 = new ListBox();
			CloseStatisticsBtn = new Button();
			resetStatisticsBtn = new Button();
			groupBox1 = new GroupBox();
			splitContainer1 = new SplitContainer();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced" });
			listBox1.Location = new Point(12, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(120, 94);
			listBox1.TabIndex = 1;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// CloseStatisticsBtn
			// 
			CloseStatisticsBtn.Location = new Point(354, 230);
			CloseStatisticsBtn.Name = "CloseStatisticsBtn";
			CloseStatisticsBtn.Size = new Size(153, 26);
			CloseStatisticsBtn.TabIndex = 2;
			CloseStatisticsBtn.Text = "Close";
			CloseStatisticsBtn.UseVisualStyleBackColor = true;
			CloseStatisticsBtn.Click += CloseStatisticsBtn_Click;
			// 
			// resetStatisticsBtn
			// 
			resetStatisticsBtn.Location = new Point(513, 230);
			resetStatisticsBtn.Name = "resetStatisticsBtn";
			resetStatisticsBtn.Size = new Size(153, 26);
			resetStatisticsBtn.TabIndex = 3;
			resetStatisticsBtn.Text = "Reset";
			resetStatisticsBtn.UseVisualStyleBackColor = true;
			resetStatisticsBtn.Click += resetStatisticsBtn_Click;
			// 
			// groupBox1
			// 
			groupBox1.Location = new Point(138, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(200, 131);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Best Times";
			// 
			// splitContainer1
			// 
			splitContainer1.Location = new Point(354, 12);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Size = new Size(289, 181);
			splitContainer1.SplitterDistance = 173;
			splitContainer1.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 11);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// Statistics
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(686, 267);
			Controls.Add(splitContainer1);
			Controls.Add(groupBox1);
			Controls.Add(resetStatisticsBtn);
			Controls.Add(CloseStatisticsBtn);
			Controls.Add(listBox1);
			Name = "Statistics";
			Text = "KotMinesweeper";
			Load += Statistics_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private ListBox listBox1;
		private Button CloseStatisticsBtn;
		private Button resetStatisticsBtn;
		private GroupBox groupBox1;
		private SplitContainer splitContainer1;
		private Label label1;
	}
}