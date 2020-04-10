using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface ITeamService
	{
		int Put(Team team);

		IEnumerable<Team> GetAll();

		Team GetById(int id);

		int Update(Team team);

		int DeleteById(int id);
	}
}
