using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface ISportEventService
	{
		int Put(SportEventViewModel sportEventViewModel);

		IEnumerable<SportEventViewModel> GetAll();

		IEnumerable<SportEventViewModel> GetBySportId(int sportId);

		SportEventViewModel GetById(int id);

		int Update(SportEventViewModel sportEventViewModel);

		int DeleteById(int id);
	}
}
