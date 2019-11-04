using SavePrincessGame.General;

namespace SavePrincessGame.UI
{
	class Handler
	{
		private readonly ConsoleReader reader;
		private readonly ConsoleWriter writer;
		private readonly Game game;

		public Handler(Game game)
		{
			this.game = game;
			reader = new ConsoleReader();
			writer = new ConsoleWriter(game);
		}

		internal void Start()
		{
			writer.WriteGame();

			while (game.Hero.IsAlive)
			{
				Key key = reader.Read();
				HandleKey(key);
				writer.WriteActivatedTraps();
			}

			//GameOver();
		}

		private void HandleKey(Key key)
		{
			var direction = new MoveDirection();

			switch (key)
			{
				case Key.Up:
					direction = MoveDirection.Up;
					break;
				case Key.Down:
					direction = MoveDirection.Down;
					break;
				case Key.Right:
					direction = MoveDirection.Right;
					break;
				case Key.Left:
					direction = MoveDirection.Left;
					break;
				case Key.Exit:
					//
					break;
				case Key.Reload:
					//
					break;
				case Key.Nonexistent:
				default:
					return;
			}

			if (game.MoveHero(direction) == true)
			{
				writer.WriteMovement(game.Hero);
			}
		}
	}
}
