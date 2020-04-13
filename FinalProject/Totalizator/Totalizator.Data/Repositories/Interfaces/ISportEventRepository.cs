using System.Collections.Generic;
using Totalizator.Data.Models;

namespace Totalizator.Data.Repositories.Interfaces
{
	public interface ISportEventRepository
	{
		int Put(SportEvent sportEvent);

		IEnumerable<SportEvent> GetAll();

		IEnumerable<SportEvent> GetBySportId(int sportId);

		SportEvent GetById(int id);

		int Update(SportEvent sportEvent);

		int DeleteById(int id);
	}
}
