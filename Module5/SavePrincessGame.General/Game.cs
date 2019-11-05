using System;
using System.Collections.Generic;

namespace SavePrincessGame.General
{
	public class Game
	{
		public Hero Hero { get; }
		public List<Trap> Traps { get; }
		public List<Wall> Walls { get; }
		public Princess Princess { get; }
		public List<IPlaceble> Field { get; }

		public Game(Cell startedHeroCell, int heroHP, int numberOfTraps, int fieldHeight, int fieldWidth, Cell princessCell)
		{
			Field = new List<IPlaceble>();
			Walls = CreateWalls(fieldHeight, fieldWidth);
			Field.AddRange(Walls);
			Hero = new Hero(startedHeroCell, heroHP);
			Field.Add(Hero);
			Princess = new Princess(princessCell);
			Field.Add(Princess);
			Traps = CreateTraps(numberOfTraps, fieldHeight, fieldWidth);
		}

		private List<Wall> CreateWalls(int fieldHeight, int fieldWidth)
		{
			fieldHeight += 2;
			fieldWidth += 2;

			int numberOfWalls = fieldHeight * 2 + fieldWidth * 2;
			List<Wall> walls = new List<Wall>(numberOfWalls);

			int column = -1;
			int row = -1;

			for (; column < fieldWidth - 1; column++)
			{
				var wall = new Wall(new Cell(column, row));
				walls.Add(wall);
			}

			for (; row < fieldHeight - 1; row++)
			{
				var wall = new Wall(new Cell(column, row));
				walls.Add(wall);
			}

			for (; column > -1; column--)
			{
				var wall = new Wall(new Cell(column, row));
				walls.Add(wall);
			}

			for (; row > -1; row--)
			{
				var wall = new Wall(new Cell(column, row));
				walls.Add(wall);
			}

			return walls;
		}

		private List<Trap> CreateTraps(int numberOfTraps, int fieldHeight, int fieldWidth)
		{
			var random = new Random();

			var traps = new List<Trap>(numberOfTraps);

			for (int index = 0; index < numberOfTraps; index++)
			{
				if (index == fieldHeight * fieldWidth - 2)
				{
					break;
				}

				Cell cell;
				do
				{
					int column = random.Next(0, fieldWidth + 1);
					int row = random.Next(0, fieldHeight + 1);
					cell = new Cell(column, row);
				}
				while (traps.Exists(tr => tr.OccupiedCell.Equals(cell)));

				int trapDamage = random.Next(1, 11);
				var trap = new Trap(trapDamage, cell);

				if (Field.Exists(element => element.OccupiedCell.Equals(trap.OccupiedCell)))
				{
					index--;
					continue;
				}

				traps.Add(trap);
				Field.Add(trap);
			}

			return traps;
		}

		public bool MoveHero(MoveDirection direction)
		{
			var lastCell = Hero.OccupiedCell;
			var nextCell = lastCell;
			bool isHeroMoved = true;
	
			switch (direction)
			{
				case MoveDirection.Up:
					nextCell.Row--;
					break;
				case MoveDirection.Down:
					nextCell.Row++;
					break;
				case MoveDirection.Right:
					nextCell.Column++;
					break;
				case MoveDirection.Left:
					nextCell.Column--;
					break;
				case MoveDirection.Nonexistent:
				default:
					return false;
			}

			if (IsNextCellOccupied(nextCell))
			{
				isHeroMoved = InterractWith(nextCell);
			}
			if (isHeroMoved)
			{
				Hero.MoveTo(nextCell);
			}
			return isHeroMoved;
		}

		private bool IsNextCellOccupied(Cell nextCell)
		{
			if (Field.Exists(entity => entity.OccupiedCell.Equals(nextCell)))
			{
				return true;
			}
			return false;
		}

		private bool InterractWith(Cell cellToInterract)
		{
			bool HeroCanMove;
			if (cellToInterract.Equals(Princess.OccupiedCell))
			{
				//GetWin();
				return false;
			}

			var trap = Traps.Find(tr => tr.OccupiedCell.Equals(cellToInterract));
			if (trap != null)
			{
				if (trap.IsActivated)
				{
					HeroCanMove = true;
					return HeroCanMove;
				}
				trap.IsActivated = true;
				Hero.HP -= trap.Damage;
				HeroCanMove = true;
				return HeroCanMove;
			}
			HeroCanMove = false;
			return HeroCanMove;
		}
	}
}