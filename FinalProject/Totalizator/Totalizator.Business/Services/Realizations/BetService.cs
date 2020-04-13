using AutoMapper;
using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Models;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class BetService : IBetService
	{
		private readonly IBetRepository betRepository;
		private readonly IMapper mapper;

		public BetService(IBetRepository repository)
		{
			betRepository = repository;
			mapper = new MapperConfiguration(cfg => cfg.CreateMap<BetViewModel, Bet>()).CreateMapper();
		}

		public int Put(BetViewModel betViewModel)
		{
			return betRepository.Put(mapper.Map<BetViewModel, Bet>(betViewModel));
		}

		public IEnumerable<BetViewModel> GetAll()
		{
			return mapper.Map<IEnumerable<Bet>, IEnumerable<BetViewModel>>(betRepository.GetAll());
		}

		public BetViewModel GetById(int id)
		{
			return mapper.Map<Bet, BetViewModel>(betRepository.GetById(id));
		}

		public IEnumerable<BetViewModel> GetByUserId(int userId)
		{
			return mapper.Map<IEnumerable<Bet>, IEnumerable<BetViewModel>>(betRepository.GetByUserId(userId));
		}

		public int Update(BetViewModel betViewModel)
		{
			return betRepository.Update(mapper.Map<BetViewModel, Bet>(betViewModel));
		}

		public int DeleteById(int id)
		{
			return betRepository.DeleteById(id);
		}
	}
}
