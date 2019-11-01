namespace SavePrincessGame.General
{
	class Hero : IPlaceble
	{
		private int hp;

		public Cell OccupiedCell { get; set; }
		public int HP 
		{ 
			get => hp; 
			set
			{
				if (value >= MinHP && value <= MaxHP)
				{
					hp = value;
				}
			}
		}
		public int MaxHP { get; set; }
		public int MinHP { get; }

		public Hero(Cell startedCell, int minHp, int maxHP)
		{
			OccupiedCell = startedCell;
			MinHP = minHp;
			MaxHP = maxHP;
			HP = MaxHP;
		}

		public void MoveTo(Cell nextCell)
		{
			OccupiedCell = nextCell;
		}
	}
}
