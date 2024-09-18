namespace KotMineSweeper
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			menuStrip = new MenuStrip();
			gameToolStripMenuItem = new ToolStripMenuItem();
			newGameToolStripMenuItem = new ToolStripMenuItem();
			statisticsToolStripMenuItem = new ToolStripMenuItem();
			optionsToolStripMenuItem = new ToolStripMenuItem();
			changeAppearanceToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			viewHelpToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			aboutKotMinesweeperToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator3 = new ToolStripSeparator();
			getMoreGamesOnlineToolStripMenuItem = new ToolStripMenuItem();
			bindingSource1 = new BindingSource(components);
			tableLayoutPanel1 = new TableLayoutPanel();
			smileBtn = new Button();
			lblTimer = new Label();
			lblMinesLeft = new Label();
			menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip
			// 
			menuStrip.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, helpToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(191, 24);
			menuStrip.TabIndex = 0;
			menuStrip.Text = "MenuStrip";
			// 
			// gameToolStripMenuItem
			// 
			gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, statisticsToolStripMenuItem, optionsToolStripMenuItem, changeAppearanceToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
			gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			gameToolStripMenuItem.Size = new Size(50, 20);
			gameToolStripMenuItem.Text = "Game";
			// 
			// newGameToolStripMenuItem
			// 
			newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			newGameToolStripMenuItem.ShortcutKeys = Keys.F2;
			newGameToolStripMenuItem.Size = new Size(200, 22);
			newGameToolStripMenuItem.Text = "New Game";
			// 
			// statisticsToolStripMenuItem
			// 
			statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
			statisticsToolStripMenuItem.ShortcutKeys = Keys.F4;
			statisticsToolStripMenuItem.Size = new Size(200, 22);
			statisticsToolStripMenuItem.Text = "Statistics";
			statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click;
			// 
			// optionsToolStripMenuItem
			// 
			optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			optionsToolStripMenuItem.ShortcutKeys = Keys.F5;
			optionsToolStripMenuItem.Size = new Size(200, 22);
			optionsToolStripMenuItem.Text = "Options";
			// 
			// changeAppearanceToolStripMenuItem
			// 
			changeAppearanceToolStripMenuItem.Name = "changeAppearanceToolStripMenuItem";
			changeAppearanceToolStripMenuItem.ShortcutKeys = Keys.F7;
			changeAppearanceToolStripMenuItem.Size = new Size(200, 22);
			changeAppearanceToolStripMenuItem.Text = "Change Appearance";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(197, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(200, 22);
			exitToolStripMenuItem.Text = "Exit";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHelpToolStripMenuItem, toolStripSeparator2, aboutKotMinesweeperToolStripMenuItem, toolStripSeparator3, getMoreGamesOnlineToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(44, 20);
			helpToolStripMenuItem.Text = "Help";
			// 
			// viewHelpToolStripMenuItem
			// 
			viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
			viewHelpToolStripMenuItem.ShortcutKeys = Keys.F1;
			viewHelpToolStripMenuItem.Size = new Size(200, 22);
			viewHelpToolStripMenuItem.Text = "View Help";
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(197, 6);
			// 
			// aboutKotMinesweeperToolStripMenuItem
			// 
			aboutKotMinesweeperToolStripMenuItem.Name = "aboutKotMinesweeperToolStripMenuItem";
			aboutKotMinesweeperToolStripMenuItem.Size = new Size(200, 22);
			aboutKotMinesweeperToolStripMenuItem.Text = "About KotMinesweeper";
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(197, 6);
			// 
			// getMoreGamesOnlineToolStripMenuItem
			// 
			getMoreGamesOnlineToolStripMenuItem.Name = "getMoreGamesOnlineToolStripMenuItem";
			getMoreGamesOnlineToolStripMenuItem.Size = new Size(200, 22);
			getMoreGamesOnlineToolStripMenuItem.Text = "Get More Games Online";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.848484F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.151516F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
			tableLayoutPanel1.Controls.Add(smileBtn, 1, 0);
			tableLayoutPanel1.Controls.Add(lblTimer, 2, 0);
			tableLayoutPanel1.Controls.Add(lblMinesLeft, 0, 0);
			tableLayoutPanel1.Location = new Point(12, 38);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(167, 40);
			tableLayoutPanel1.TabIndex = 0;
			tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
			// 
			// smileBtn
			// 
			smileBtn.BackgroundImage = (Image)resources.GetObject("smileBtn.BackgroundImage");
			smileBtn.BackgroundImageLayout = ImageLayout.Zoom;
			smileBtn.Location = new Point(65, 3);
			smileBtn.Name = "smileBtn";
			smileBtn.Size = new Size(36, 34);
			smileBtn.TabIndex = 0;
			smileBtn.UseVisualStyleBackColor = true;
			smileBtn.Click += smileBtn_Click;
			// 
			// lblTimer
			// 
			lblTimer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblTimer.AutoSize = true;
			lblTimer.BackColor = Color.Red;
			lblTimer.Location = new Point(107, 12);
			lblTimer.Name = "lblTimer";
			lblTimer.Size = new Size(57, 15);
			lblTimer.TabIndex = 1;
			// 
			// lblMinesLeft
			// 
			lblMinesLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblMinesLeft.AutoSize = true;
			lblMinesLeft.BackColor = Color.Red;
			lblMinesLeft.Location = new Point(3, 12);
			lblMinesLeft.Name = "lblMinesLeft";
			lblMinesLeft.Size = new Size(56, 15);
			lblMinesLeft.TabIndex = 2;
			lblMinesLeft.Click += lblMinesLeft_Click;
			// 
			// Form1
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(191, 268);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(menuStrip);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip;
			Name = "Form1";
			Text = "KotMinesweeper";
			Load += Form1_Load;
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip;
		private ToolStripMenuItem gameToolStripMenuItem;
		private ToolStripMenuItem newGameToolStripMenuItem;
		private ToolStripMenuItem statisticsToolStripMenuItem;
		private ToolStripMenuItem optionsToolStripMenuItem;
		private ToolStripMenuItem changeAppearanceToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private BindingSource bindingSource1;
		private ToolStripMenuItem viewHelpToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem aboutKotMinesweeperToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem getMoreGamesOnlineToolStripMenuItem;
		private TableLayoutPanel tableLayoutPanel1;
		private Button smileBtn;
		private Label lblTimer;
		private Label lblMinesLeft;
	}
}
