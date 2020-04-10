using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IBetService
	{
		int Put(Bet bet);

		IEnumerable<Bet> GetAll();

		Bet GetById(int id);

		IEnumerable<Bet> GetByUserId(int userId);

		int Update(Bet bet);

		int DeleteById(int id);
	}
}
