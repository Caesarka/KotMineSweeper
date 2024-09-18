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
					btn.Tag = (x, y);
					btn.Width = btnSize;
					btn.Height = btnSize;
					btn.Left = x * btnSize + 5;
					btn.Top = y * btnSize + menuStrip.Height + 15 + 40;
					this.Controls.Add(btn);
					btn.Click += Button_Click;
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

		public void Button_Click(object sender, EventArgs e)
		{
			
			if (!_isTimerStarted)
			{
				_startTime = DateTime.Now;
				_timer.Start();
				_isTimerStarted = true;
			}
			Button clickedBtn = (Button)sender;
			var index = ((int, int))clickedBtn.Tag;
			var cellData = _cells[index.Item1, index.Item2];
			clickedBtn.BackColor = cellData.Value ? Color.LightGray : Color.Red;
			var neighbours = GetNeighbours(index);
			
			if (cellData.Value)
			{
				var cntMine = CountMine(neighbours);
				clickedBtn.Text = cntMine.ToString();
				if (cntMine == 0)
				{

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

		public int CountMine(List<(int X, int Y)> neighbours)
		{
			var count = 0;
			foreach (var neighbour in neighbours)
			{
				if (_cells[neighbour.X, neighbour.Y].Value == false)
				{
					count++;
				}
			}
			return count;
		}

		public List<(int X, int Y)> GetNeighbours((int X, int Y) index)
		{
			var neighbours = new List<(int X, int Y)>();
			for (int x = index.X - 1; x <= index.X + 1; x++)
			{
				for (int y = index.Y - 1; y <= index.Y + 1; y++)
				{
					if (x >= 0 && x < SIZE)
					{
						if (y >= 0 && y < SIZE)
						{
							if (x != index.X || y != index.Y)
							{
								neighbours.Add((x, y));
							}
						}
					}
				}
			}
			foreach ((int X, int Y) neighbour in neighbours)
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
