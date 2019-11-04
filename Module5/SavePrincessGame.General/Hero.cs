namespace SavePrincessGame.General
{
	public class Hero : IPlaceble
	{
		private int hp;

		public Cell OccupiedCell { get; set; }
		public Cell LastCell { get; set; }
		public bool IsAlive;
		public int HP 
		{ 
			get => hp; 
			set
			{
				if (value > 0)
				{
					hp = value;
				}
				else if (value <= 0)
				{
					hp = 0;
					IsAlive = false;
				}
			}
		}

		public Hero(Cell startedCell, int HP)
		{
			IsAlive = true;
			OccupiedCell = startedCell;
			this.HP = HP;
		}

		public void MoveTo(Cell nextCell)
		{
			LastCell = OccupiedCell;
			OccupiedCell = nextCell;
		}
	}
}
