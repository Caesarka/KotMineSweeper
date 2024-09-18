using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotMineSweeper
{
	public class CellData
	{
		int X;
		int Y;
		public bool Value;

		public CellData(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
