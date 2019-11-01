namespace SavePrincessGame.General
{
	class Cell
	{
		public int Row { get; set; }
		public int Line { get; set; }

		public Cell(int row, int line)
		{
			Row = row;
			Line = line;
		}
	}
}
