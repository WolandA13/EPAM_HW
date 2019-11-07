using System;
using SavePrincessGame.General;

namespace SavePrincessGame.UI
{
	class Handler
	{
		private ConsoleReader reader;
		private ConsoleWriter writer;
		private Game game;

		public Handler()
		{
			CreateNewGame();
		}

		private void CreateNewGame()
		{
			game = new Game
				(
				startedHeroCell: new Cell(0, 0),
				heroHP: 10,
				numberOfTraps: 10,
				fieldWidth: 10,
				fieldHeight: 10,
				princessCell: new Cell(10, 10)
				);

			reader = new ConsoleReader();
			writer = new ConsoleWriter(game);
		}

		internal GameEndSituation Start()
		{
			GameEndSituation gameEndSituation = GameEndSituation.NotHappened;
			writer.WriteGame();

			while (gameEndSituation == GameEndSituation.NotHappened)
			{
				writer.WriteHPBar();
				Key key = reader.ReadKey();
				gameEndSituation = HandleKey(key);
				writer.WriteActivatedTraps();
				
				if (game.Princess.WasEscaped)
				{
					gameEndSituation = GameEndSituation.Win;
				}

				if (game.Hero.IsAlive == false)
				{
					gameEndSituation = GameEndSituation.HeroDeath;
				}
			}

			return gameEndSituation;
		}

		private GameEndSituation HandleKey(Key key)
		{
			var direction = MoveDirection.Nonexistent;

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
					return GameEndSituation.Exit;
				case Key.Restart:
					return GameEndSituation.Restart;
				case Key.Nonexistent:
				default:
					return GameEndSituation.NotHappened;
			}

			if (game.MoveHero(direction) == true)
			{
				writer.WriteMovement(game.Hero);
			}

			return GameEndSituation.NotHappened;
		}

		internal bool HandleGameEnd(GameEndSituation gameEndSituation)
		{
			switch (gameEndSituation)
			{
				case GameEndSituation.Exit:
					writer.AskUser("Вы точно хотите выйти?");
					return HandleExitOrContinue(reader.GetUserAnswer());
				case GameEndSituation.HeroDeath:
					writer.AskUser("Вы умерли. Хотите попробовать [умереть] ещё раз?");
					return HandleRestartOrExit(reader.GetUserAnswer());
				case GameEndSituation.Restart:
					writer.AskUser("Вы хотите начать новую игру?");
					return HandleRestartOrContinue(reader.GetUserAnswer());
				case GameEndSituation.Win:
					writer.AskUser("Поздравляю, Вы победили! Начать новую игру?");
					return HandleRestartOrExit(reader.GetUserAnswer());
				default:
					writer.AskUser("Вы хотите начать новую игру?");
					return HandleRestartOrExit(reader.GetUserAnswer());
			}
		}

		private bool HandleRestartOrContinue(UserAnswer userAnswer)
		{
			if (userAnswer == UserAnswer.Yes)
			{
				CreateNewGame();
			}
			Console.Clear();
			return true;
		}

		private bool HandleExitOrContinue(UserAnswer userAnswer)
		{
			if (userAnswer == UserAnswer.Yes)
			{
				return false;
			}
			return true;
		}

		private bool HandleRestartOrExit(UserAnswer userAnswer)
		{
			if (userAnswer == UserAnswer.Yes)
			{
				CreateNewGame();
				Console.Clear();
				return true;
			}
			return false;
		}
	}
}
