using AutoMapper;
using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Models;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class TeamService : ITeamService
	{
		private readonly ITeamRepository teamRepository;
		private readonly IMapper mapper;

		public TeamService(ITeamRepository teamRepo)
		{
			teamRepository = teamRepo;
			mapper = new MapperConfiguration(cfg => cfg.CreateMap<TeamViewModel, Team>()).CreateMapper();
		}

		public int Put(TeamViewModel teamViewModel)
		{
			return teamRepository.Put(mapper.Map<TeamViewModel, Team>(teamViewModel));
		}

		public IEnumerable<TeamViewModel> GetAll()
		{
			return mapper.Map<IEnumerable<Team>, IEnumerable<TeamViewModel>>(teamRepository.GetAll());
		}

		public TeamViewModel GetById(int id)
		{
			return mapper.Map<Team, TeamViewModel>(teamRepository.GetById(id));
		}

		public int Update(TeamViewModel teamViewModel)
		{
			return teamRepository.Update(mapper.Map<TeamViewModel, Team>(teamViewModel));
		}
		
		public int DeleteById(int id)
		{
			return teamRepository.DeleteById(id);
		}
	}
}
