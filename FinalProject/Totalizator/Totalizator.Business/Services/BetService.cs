using System.Collections.Generic;
using Totalizator.Data.Repositories;
using Totalizator.Shared.Realization;

namespace Totalizator.Business.Services
{
	public class BetService
	{
		private readonly BetRepository betRepository;

		public BetService()
		{
			betRepository = new BetRepository();
		}

		public void Put(Bet bet)
		{
			betRepository.Put(bet);
		}

		public List<Bet> GetAll()
		{
			return betRepository.GetAll();
		}

		public Bet GetById(int id)
		{
			return betRepository.GetById(id);
		}

		public List<Bet> GetByUserId(int userId)
		{
			return betRepository.GetByUserId(userId);
		}

		public void Update(Bet bet)
		{
			betRepository.Update(bet);
		}

		public void DeleteById(int id)
		{
			betRepository.DeleteById(id);
		}
	}
}
