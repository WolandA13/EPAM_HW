using System.Collections.Generic;
using Totalizator.Data.Models;

namespace Totalizator.Data.Repositories.Interfaces
{
	public interface IBetRepository
	{
		int Put(Bet bet);

		IEnumerable<Bet> GetAll();

		Bet GetById(int id);

		IEnumerable<Bet> GetByUserId(int userId);

		int Update(Bet bet);

		int DeleteById(int id);
	}
}
