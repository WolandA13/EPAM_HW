namespace SavePrincessGame.General
{
	class Trap : IPlaceble
	{
		public Cell OccupiedCell { get; set; }
		public int Damage { get; set; }

		public Trap(int damage)
		{
			Damage = damage;
		}
	}
}