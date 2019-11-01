using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavePrincessGame.General
{
	class Game
	{
		public Field Field { get; }

		public Game()
		{
			Field = new Field(new Hero(new Cell(0, 0), 0, 10), new List<Trap>(10));
		}
	}
}