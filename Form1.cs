using KotMineSweeper.Properties;
using System.Diagnostics;
using System.Drawing.Text;
using static KotMineSweeper.CellData;
using static System.Runtime.InteropServices.JavaScript.JSType;


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
			lblMinesLeft.Text = _minesLeft.ToString();
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
					_cells[x, y].Button = btn;
					btn.Width = btnSize;
					btn.Height = btnSize;
					btn.Left = x * btnSize;
					btn.Top = y * btnSize;
					map.Controls.Add(btn);
					btn.MouseDown += Btn_MouseClick;
					btn.Click += Button_Click;
				}
			}
		}

		private void Btn_MouseClick(object? sender, MouseEventArgs e)
		{
			var btn = (Button?)sender;
			CellData? data = (CellData)btn.Tag;

			if (e.Button == MouseButtons.Right)
			{
				if (data.Flag == false)
				{
					data.Flag = true;
					btn.Text = "\uD83D\uDEA9";
					_minesLeft--;
				}
				else
				{
					data.Flag = false;
					btn.Text = "";
					_minesLeft++;
				}
				lblMinesLeft.Text = _minesLeft.ToString();
			}
			if (e.Button == MouseButtons.Middle)
			{
				var neighbours = GetNeighbours(data);
				var cntMines = CountMine(neighbours);
				var cntFlags = CountFlag(neighbours);
				if (cntFlags == cntMines)
				{
					foreach (var neighbour in neighbours)
					{
						if (!neighbour.Flag)
						{
							Button_Click(neighbour.Button, EventArgs.Empty);
						}
					}
				}
			}
		}

		public int CountFlag(List<CellData> neighbours)
		{
			var count = 0;
			foreach (var neighbour in neighbours)
			{
				if (neighbour.Flag == true)
				{
					count++;
				}
			}
			return count;
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
				foreach (var cell in _cells)
				{
					if (cell.Value == false)
					{
						cell.Button.BackgroundImage = Resources.bomb;
						cell.Button.BackgroundImageLayout = ImageLayout.Stretch;
						cell.Button.Refresh();
					}
				}

				smileBtn.BackgroundImage = Resources.sad_smile;
				smileBtn.BackgroundImageLayout = ImageLayout.Stretch;
				smileBtn.Refresh();
				map.Enabled = false;
				_timer.Stop();

			}

			cellData.IsOpen = true;
			var neighbours = GetNeighbours(cellData);

			if (cellData.Value)
			{
				var cntMine = CountMine(neighbours);
				if (cntMine > 0)
				{
					switch (cntMine)
					{
						case 1:
							clickedBtn.ForeColor = Color.Blue;
							break;
						case 2:
							clickedBtn.ForeColor = Color.Green;
							break;
						case 3:
							clickedBtn.ForeColor = Color.Red;
							break;
						case 4:
							clickedBtn.ForeColor = Color.DarkBlue;
							break;
						case 5:
							clickedBtn.ForeColor = Color.DarkRed;
							break;
						case 6:
							clickedBtn.ForeColor = Color.Cyan;
							break;
						case 7:
							clickedBtn.ForeColor = Color.Purple;
							break;
						case 8:
							clickedBtn.ForeColor = Color.DarkGray;
							break;
					}

					clickedBtn.Text = cntMine.ToString();
				}
				if (cntMine == 0)
				{
					foreach (var neighbour in neighbours)
					{
						if (!neighbour.IsOpen)
						{
							Button_Click(neighbour.Button, e);
						}
					}
				}
			}

			var countOpen = 0;
			foreach (var cell in _cells)
			{
				if (cell.IsOpen)
				{
					countOpen++;
				}
			}
			if (countOpen == (SIZE * SIZE) - MINES)
			{
				_timer.Stop();
				smileBtn.BackgroundImage = Resources.win;
				smileBtn.BackgroundImageLayout = ImageLayout.Stretch;
				smileBtn.Refresh();
				map.Enabled = false;
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

		private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Statistics statistics = new Statistics();
			statistics.Show();
		}

		private void smileBtn_Click(object sender, EventArgs e)
		{
			smileBtn.BackgroundImage = Resources.smile;
			smileBtn.BackgroundImageLayout = ImageLayout.Stretch;
			smileBtn.Refresh();
			map.Controls.Clear();
			map.Enabled = true;
			CreateGrid();
			_timer.Stop();
			_isTimerStarted = false;
			_startTime = default;
			_minesLeft = MINES;
			lblTimer.Text = "0";
			lblMinesLeft.Text = _minesLeft.ToString();
		}
	}
}
