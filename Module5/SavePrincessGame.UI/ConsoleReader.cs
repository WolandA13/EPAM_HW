using System;

namespace SavePrincessGame.UI
{
	class ConsoleReader
	{
		internal Key Read()
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
					key = Key.Reload;
					break;
				default:
					key = Key.Nonexistent;
					break;
			}

			return key;
		}
	}
}
