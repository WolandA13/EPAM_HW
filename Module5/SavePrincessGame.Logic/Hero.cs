namespace SavePrincessGame.Logic
{
	class Hero : IPlaceble
	{
		public Cell OccupiedCell { get; set; }
		public int HP { get; set; }
		public int MaxHP { get; set; }

		public Hero(Cell startedCell, int maxHP)
		{
			OccupiedCell = startedCell;
			MaxHP = maxHP;
			HP = MaxHP;
		}

		public void MoveTo(Cell nextCell)
		{
			OccupiedCell = nextCell;
		}
	}
}
