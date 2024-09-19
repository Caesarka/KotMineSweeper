using KotMineSweeper.Properties;
using System.Diagnostics;
using System.Drawing.Text;
using static KotMineSweeper.CellData;


namespace KotMineSweeper
{
	public partial class Form1 : Form
	{
		const int SIZE = 9;
		const int MINES = 10;
		CellData[,] _cells;
		System.Windows.Forms.Timer _timer;
		DateTime _startTime;
		bool _isTimerStarted = false;
		int _minesLeft = MINES;

		public Form1()
		{
			InitializeComponent();
			CreateGrid();
			_timer = new System.Windows.Forms.Timer();
			_timer.Interval = 1000;
			_timer.Tick += TimerTick;
			lblMinesLeft.Text += _minesLeft.ToString();
		}

		private void TimerTick(object sender, EventArgs e)
		{
			TimeSpan elapsedTime = DateTime.Now - _startTime;
			lblTimer.Text = elapsedTime.Seconds.ToString();
		}

		public void CreateGrid()
		{
			_cells = GenerateRandomValues();
			var btnSize = 20;
			for (int y = 0; y < SIZE; y++)
			{
				for (int x = 0; x < SIZE; x++)
				{
					Button btn = new Button();
					btn.Tag = _cells[x, y];
					_cells[x, y].button = btn;
					btn.Width = btnSize;
					btn.Height = btnSize;
					btn.Left = x * btnSize + 5;
					btn.Top = y * btnSize + menuStrip.Height + 15 + 40;
					this.Controls.Add(btn);
					btn.MouseDown += Btn_MouseClick;
					btn.Click += Button_Click;
				}
			}
		}

		private void Btn_MouseClick(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var btn = (Button?)sender;
				CellData? data = (CellData)btn.Tag;
				if (data.Flag == false) { data.Flag = true; }
				else { data.Flag = false; }
				if (data.Flag == false)
				{
					btn.Text = "";
				}
				else
				{
					btn.Text = "\uD83D\uDEA9";
				}
			}
		}

		public CellData[,] GenerateRandomValues()
		{
			var binaryValues = new CellData[SIZE, SIZE];
			var tempBinaryValues = new List<bool>();
			tempBinaryValues.AddRange(Enumerable.Repeat(false, MINES));
			tempBinaryValues.AddRange(Enumerable.Repeat(true, SIZE * SIZE - MINES));
			Random rnd = new Random();
			tempBinaryValues = tempBinaryValues.OrderBy(x => rnd.Next()).ToList();

			for (int y = 0; y < SIZE; y++)
			{
				for (int x = 0; x < SIZE; x++)
				{
					binaryValues[x, y] = new CellData(x, y)
					{
						Value = tempBinaryValues[y * SIZE + x],
					};
				}
			}
			return binaryValues;
		}

		public void Button_Click(object? sender, EventArgs e)
		{
			if (!_isTimerStarted)
			{
				_startTime = DateTime.Now;
				_timer.Start();
				_isTimerStarted = true;
			}

			Button clickedBtn = (Button)sender;
			var cellData = (CellData)clickedBtn.Tag;
			clickedBtn.BackColor = cellData.Value ? Color.LightGray : Color.Red;

			if (clickedBtn.BackColor == Color.Red)
			{
				clickedBtn.BackgroundImage = Resources.bomb;
				clickedBtn.BackgroundImageLayout = ImageLayout.Stretch;
				clickedBtn.Refresh();
				smileBtn.BackgroundImage = Resources.sad_smile;
				smileBtn.BackgroundImageLayout = ImageLayout.Stretch;
				smileBtn.Refresh();
			}

			clickedBtn.Enabled = false;
			cellData.isOpen = true;
			var neighbours = GetNeighbours(cellData);
			
			if (cellData.Value)
			{
				var cntMine = CountMine(neighbours);
				clickedBtn.Text = cntMine.ToString();
				if (cntMine == 0)
				{
					foreach (var neighbour in neighbours)
					{
						if (!neighbour.isOpen)
						{
							Button_Click(neighbour.button, e);
						}
					}
				}
			}
			else
			{
				_minesLeft--;
				lblMinesLeft.Text = _minesLeft.ToString();
			}

			if (_minesLeft == 0)
			{
				_timer.Stop();
				smileBtn.BackgroundImage = Resources.win;
				smileBtn.BackgroundImageLayout = ImageLayout.Stretch;
				smileBtn.Refresh();
			}
		}

		public int CountMine(List<CellData> neighbours)
		{
			var count = 0;
			foreach (var neighbour in neighbours)
			{
				if (neighbour.Value == false)
				{
					count++;
				}
			}
			return count;
		}

		public List<CellData> GetNeighbours(CellData cellData)
		{
			var neighbours = new List<CellData>();
			for (int x = cellData.X - 1; x <= cellData.X + 1; x++)
			{
				for (int y = cellData.Y - 1; y <= cellData.Y + 1; y++)
				{
					if (x >= 0 && x < SIZE)
					{
						if (y >= 0 && y < SIZE)
						{
							if (x != cellData.X || y != cellData.Y)
							{
								neighbours.Add(_cells[x, y]);
							}
						}
					}
				}
			}
			foreach (var neighbour in neighbours)
			{
				Trace.WriteLine($"{neighbour.X}, {neighbour.Y}");
			}
			Trace.WriteLine("--------------------");

			return neighbours;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Statistics statistics = new Statistics();
			statistics.Show();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void smileBtn_Click(object sender, EventArgs e)
		{
			_timer.Stop();
		}

		private void lblMinesLeft_Click(object sender, EventArgs e)
		{

		}
	}
}
