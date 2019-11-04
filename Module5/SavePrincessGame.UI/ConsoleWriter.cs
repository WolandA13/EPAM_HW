using SavePrincessGame.General;
using System;
using System.Linq;

namespace SavePrincessGame.UI
{
	class ConsoleWriter
	{
		private readonly int columnOffset;
		private readonly int rowOffset;
		private readonly Game game;

		public ConsoleWriter(Game game)
		{
			Console.CursorVisible = false;
			Console.BackgroundColor = ConsoleColor.Black;

			this.game = game;
			columnOffset = game.Field.Select(entity => entity.OccupiedCell.Column).Min() * -1 + 1;
			rowOffset = game.Field.Select(entity => entity.OccupiedCell.Row).Min() * -1 + 1;
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
					//color = ConsoleColor.White;
					//symbol = (entity as Trap).Damage.ToString().ToCharArray()[0];
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
	}
}