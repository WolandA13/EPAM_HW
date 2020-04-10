using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface ISportEventService
	{
		int Put(SportEvent sportEvent);

		IEnumerable<SportEvent> GetAll();

		IEnumerable<SportEvent> GetBySportId(int sportId);

		SportEvent GetById(int id);

		int Update(SportEvent sportEvent);

		int DeleteById(int id);
	}
}
