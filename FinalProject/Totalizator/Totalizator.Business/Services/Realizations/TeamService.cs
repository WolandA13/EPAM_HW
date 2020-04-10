using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class TeamService : ITeamService
	{
		private readonly ITeamRepository teamRepository;

		public TeamService(ITeamRepository teamRepo)
		{
			teamRepository = teamRepo;
		}

		public int Put(Team team)
		{
			return teamRepository.Put(team);
		}

		public IEnumerable<Team> GetAll()
		{
			return teamRepository.GetAll();
		}

		public Team GetById(int id)
		{
			return teamRepository.GetById(id);
		}

		public int Update(Team team)
		{
			return teamRepository.Update(team);
		}
		
		public int DeleteById(int id)
		{
			return teamRepository.DeleteById(id);
		}
	}
}
