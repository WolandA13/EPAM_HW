using SavePrincessGame.General;
using System;
using System.Linq;

namespace SavePrincessGame.UI
{
	class ConsoleWriter
	{
		private readonly int columnOffset;
		private readonly int rowOffset;
		private readonly int rightBoundOfField;
		private readonly int bottomBoundOfField;
		private readonly Game game;

		public ConsoleWriter(Game game)
		{
			Console.CursorVisible = false;
			Console.BackgroundColor = ConsoleColor.Black;

			this.game = game;
			columnOffset = game.Field.Select(entity => entity.OccupiedCell.Column).Min() * -1 + 1;
			rowOffset = game.Field.Select(entity => entity.OccupiedCell.Row).Min() * -1 + 1;
			rightBoundOfField = game.Field.Select(entity => entity.OccupiedCell.Column).Max() + columnOffset;
			bottomBoundOfField = game.Field.Select(entity => entity.OccupiedCell.Row).Max() + rowOffset;
		}

		internal void WriteGame()
		{
			foreach (var wall in game.Walls)
			{
				Write(wall);
			}

			foreach (var trap in game.Traps)
			{
				Write(trap);
			}
			Write(game.Hero);
			Write(game.Princess);

			WriteHPBar();
			WriteInfo();
		}

		internal void Write(IPlaceble entity)
		{
			ParamsOf(entity, out char symbol, out ConsoleColor color);

			Console.SetCursorPosition((entity.OccupiedCell.Column + columnOffset) * 2, entity.OccupiedCell.Row + rowOffset);
			Console.ForegroundColor = color;
			Console.Write(symbol);
		}

		private void ParamsOf(IPlaceble entity, out char symbol, out ConsoleColor color)
		{
			if (entity is Wall)
			{
				symbol = 'X';
				color = ConsoleColor.Gray;
				return;
			}

			if (entity is Trap)
			{
				if ((entity as Trap).IsActivated)
				{
					color = ConsoleColor.Red;
					symbol = 'o';
				}
				else
				{
					color = ConsoleColor.Black;
					symbol = ' ';
				}
				return;
			}

			if (entity is Hero)
			{
				color = ConsoleColor.Green;
				symbol = 'H';
				return;
			}

			if (entity is Princess)
			{
				color = ConsoleColor.Yellow;
				symbol = 'P';
				return;
			}

			if (entity is IPlaceble)
			{
				symbol = ' ';
				color = ConsoleColor.Black;
				return;
			}

			color = ConsoleColor.Blue;
			symbol = '?';
		}

		internal void WriteHPBar()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.SetCursorPosition(rightBoundOfField * 2 + 3, 1);
			Console.Write("{0:d2}/10 HP", game.Hero.HP);
		}

		private void WriteInfo()
		{
			string infoString = "Стрелки и WASD — управление героем (Н).\n" +
								"R — рестарт.\n" +
								"Esc — выход. \n\n" +
								"Цель игры — дойти до принцессы (P), избегая ловушек (о).";

			int lineIndex = 3;
			Console.ForegroundColor = ConsoleColor.Gray;

			foreach (string str in infoString.Split('\n'))
			{
				Console.SetCursorPosition(rightBoundOfField * 2 + 3, lineIndex);
				Console.Write(str);
				lineIndex++;
			}
		}

		internal void WriteMovement(Hero hero)
		{
			RemoveCharAt(hero.LastCell);
			Write(hero);
		}

		private void RemoveCharAt(Cell cell)
		{
			Console.SetCursorPosition((cell.Column + columnOffset) * 2, cell.Row + rowOffset);
			Console.Write(" ");
		}

		internal void WriteActivatedTraps()
		{
			foreach (var trap in game.Traps)
			{
				if (trap.IsActivated)
				{
					if (trap.OccupiedCell.Equals(game.Hero.OccupiedCell))
					{
						continue;
					}
					Write(trap);
				}
			}
		}

		internal void AskUser(string message)
		{
			Console.SetCursorPosition(1, bottomBoundOfField + 2);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(message);
			Console.WriteLine(" 1) Да; \n" +
							  " 2) Нет.");
		}
	}
}