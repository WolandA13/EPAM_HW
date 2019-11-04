using SavePrincessGame.General;
using System;

namespace SavePrincessGame.UI
{
	class Program
	{
		static void Main(string[] args)
		{
			var game = new Game
				(
				startedHeroCell: new Cell(0, 0),
				heroHP: 10,
				numberOfTraps: 10,
				fieldHeight: 10,
				fieldWidth: 10,
				princessCell: new Cell(10, 10)
				);

			var handler = new Handler(game);
			handler.Start();
		}
	}
}
