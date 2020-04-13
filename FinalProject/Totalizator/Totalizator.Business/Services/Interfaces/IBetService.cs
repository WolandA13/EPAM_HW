using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IBetService
	{
		int Put(BetViewModel betViewModel);

		IEnumerable<BetViewModel> GetAll();

		BetViewModel GetById(int id);

		IEnumerable<BetViewModel> GetByUserId(int userId);

		int Update(BetViewModel betViewModel);

		int DeleteById(int id);
	}
}
