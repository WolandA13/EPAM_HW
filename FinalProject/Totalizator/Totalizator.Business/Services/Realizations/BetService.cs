using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class BetService : IBetService
	{
		private readonly IBetRepository betRepository;

		public BetService(IBetRepository betRepo)
		{
			betRepository = betRepo;
		}

		public int Put(Bet bet)
		{
			return betRepository.Put(bet);
		}

		public IEnumerable<Bet> GetAll()
		{
			return betRepository.GetAll();
		}

		public Bet GetById(int id)
		{
			return betRepository.GetById(id);
		}

		public IEnumerable<Bet> GetByUserId(int userId)
		{
			return betRepository.GetByUserId(userId);
		}

		public int Update(Bet bet)
		{
			return betRepository.Update(bet);
		}

		public int DeleteById(int id)
		{
			return betRepository.DeleteById(id);
		}
	}
}
