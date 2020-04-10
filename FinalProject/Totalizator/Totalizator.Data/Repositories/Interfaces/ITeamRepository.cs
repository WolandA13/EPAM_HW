using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Data.Repositories.Interfaces
{
	public interface ITeamRepository
	{
		int Put(Team team);

		IEnumerable<Team> GetAll();

		Team GetById(int id);

		int Update(Team team);

		int DeleteById(int id);
	}
}
