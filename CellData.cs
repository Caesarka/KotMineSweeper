using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotMineSweeper
{
	public class CellData
	{
		public int X;
		public int Y;
		public bool Value;
		public bool Flag;
		public Button button;
		public bool isOpen;

		public CellData(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
