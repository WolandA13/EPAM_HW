namespace SavePrincessGame.UI
{
	class Program
	{
		public static void Main()
		{
			var handler = new Handler();
			bool playerWantToContinuePlaying = true;

			while (playerWantToContinuePlaying)
			{
				GameEndSituation gameEndSituation = handler.Start();
				playerWantToContinuePlaying = handler.HandleGameEnd(gameEndSituation);
			}
		}
	}
}
