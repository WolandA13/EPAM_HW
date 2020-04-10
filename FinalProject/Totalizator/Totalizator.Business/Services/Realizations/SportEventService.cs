using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class SportEventService :ISportEventService
	{
		private readonly ISportEventRepository sportEventRepository;

		public SportEventService(ISportEventRepository repo)
		{
			sportEventRepository = repo;
		}

		public int Put(SportEvent sportEvent)
		{
			return sportEventRepository.Put(sportEvent);
		}

		public IEnumerable<SportEvent> GetAll()
		{
			return sportEventRepository.GetAll();
		}

		public IEnumerable<SportEvent> GetBySportId(int sportId)
		{
			return sportEventRepository.GetBySportId(sportId);
		}

		public SportEvent GetById(int id)
		{
			return sportEventRepository.GetById(id);
		}

		public int Update(SportEvent sportEvent)
		{
			return sportEventRepository.Update(sportEvent);
		}

		public int DeleteById(int id)
		{
			return sportEventRepository.DeleteById(id);
		}
	}
}
