using System;

namespace SavePrincessGame.UI
{
	class ConsoleReader
	{
		internal Key ReadKey()
		{
			ConsoleKeyInfo pressedKey = Console.ReadKey(true);
			Key key;

			switch (pressedKey.Key)
			{
				case ConsoleKey.UpArrow:
				case ConsoleKey.W:
					key = Key.Up;
					break;
				case ConsoleKey.DownArrow:
				case ConsoleKey.S:
					key = Key.Down;
					break;
				case ConsoleKey.RightArrow:
				case ConsoleKey.D:
					key = Key.Right;
					break;
				case ConsoleKey.LeftArrow:
				case ConsoleKey.A:
					key = Key.Left;
					break;
				case ConsoleKey.Escape:
					key = Key.Exit;
					break;
				case ConsoleKey.R:
					key = Key.Restart;
					break;
				default:
					key = Key.Nonexistent;
					break;
			}

			return key;
		}

		internal UserAnswer GetUserAnswer()
		{
			var userAnswer = UserAnswer.Nonexistent;

			while (userAnswer == UserAnswer.Nonexistent)
			{
				ConsoleKeyInfo pressedKey = Console.ReadKey(true);

				switch (pressedKey.Key)
				{
					case ConsoleKey.D1:
						userAnswer = UserAnswer.Yes;
						break;
					case ConsoleKey.D2:
						userAnswer = UserAnswer.No;
						break;
					default:
						userAnswer = UserAnswer.Nonexistent;
						break;
				}
			}

			return userAnswer;
		}
	}
}
