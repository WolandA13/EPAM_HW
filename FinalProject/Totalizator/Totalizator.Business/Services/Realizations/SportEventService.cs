using AutoMapper;
using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Models;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class SportEventService :ISportEventService
	{
		private readonly ISportEventRepository sportEventRepository;
		private readonly IMapper mapper;

		public SportEventService(ISportEventRepository repo)
		{
			sportEventRepository = repo;
			mapper = new MapperConfiguration(cfg => cfg.CreateMap<SportEventViewModel, SportEvent>()).CreateMapper();
		}

		public int Put(SportEventViewModel sportEventViewModel)
		{
			return sportEventRepository.Put(mapper.Map<SportEventViewModel, SportEvent>(sportEventViewModel));
		}

		public IEnumerable<SportEventViewModel> GetAll()
		{
			return mapper.Map<IEnumerable<SportEvent>, IEnumerable<SportEventViewModel>>(sportEventRepository.GetAll());
		}

		public IEnumerable<SportEventViewModel> GetBySportId(int sportId)
		{
			return mapper.Map<IEnumerable<SportEvent>, IEnumerable<SportEventViewModel>>(sportEventRepository.GetBySportId(sportId));
		}

		public SportEventViewModel GetById(int id)
		{
			return mapper.Map<SportEvent, SportEventViewModel>(sportEventRepository.GetById(id));
		}

		public int Update(SportEventViewModel sportEventViewModel)
		{
			return sportEventRepository.Update(mapper.Map<SportEventViewModel, SportEvent>(sportEventViewModel));
		}

		public int DeleteById(int id)
		{
			return sportEventRepository.DeleteById(id);
		}
	}
}
