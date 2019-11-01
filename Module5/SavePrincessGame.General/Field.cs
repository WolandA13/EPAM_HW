using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavePrincessGame.General
{
	class Field
	{
		Hero Hero { get; set; }
		List<Trap> Traps { get; set; }

		public Field(Hero hero, List<Trap> traps)
		{
			Hero = hero;
			Traps = traps;
		}
	}
}
