namespace SavePrincessGame.General
{
	public class Princess : IPlaceble
	{
		public Cell OccupiedCell { get; set; }
		public bool WasEscaped { get; set; }

		public Princess(Cell occupiedCell)
		{
			OccupiedCell = occupiedCell;
			WasEscaped = false;
		}
	}
}
