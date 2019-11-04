namespace SavePrincessGame.General
{
	public class Trap : IPlaceble
	{
		public Cell OccupiedCell { get; set; }
		public int Damage { get; set; }
		public bool IsActivated { get; set; }

		public Trap(int damage, Cell occupiedCell)
		{
			IsActivated = false;
			Damage = damage;
			OccupiedCell = occupiedCell;
		}
	}
}