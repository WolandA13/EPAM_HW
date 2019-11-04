namespace SavePrincessGame.General
{
	public class Wall : IPlaceble
	{
		public Cell OccupiedCell { get; set; }

		public Wall(Cell occupiedCell)
		{
			OccupiedCell = occupiedCell;
		}
	}
}
