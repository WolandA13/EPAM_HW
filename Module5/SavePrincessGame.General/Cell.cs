using System;

namespace SavePrincessGame.General
{
	public struct Cell : IEquatable<Cell>
	{
		public int Column { get; set; }
		public int Row { get; set; }

		public Cell(int column, int row)
		{
			Column = column;
			Row = row;
		}

		public bool Equals(Cell otherCell)
		{
			return (Column == otherCell.Column && Row == otherCell.Row);
		}
	}
}
