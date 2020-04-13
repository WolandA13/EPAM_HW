using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface ITeamService
	{
		int Put(TeamViewModel teamViewModel);

		IEnumerable<TeamViewModel> GetAll();

		TeamViewModel GetById(int id);

		int Update(TeamViewModel teamViewModel);

		int DeleteById(int id);
	}
}
