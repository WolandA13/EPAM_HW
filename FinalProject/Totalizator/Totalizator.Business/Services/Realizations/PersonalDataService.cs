using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class PersonalDataService : IPersonalDataService
	{
		private readonly IPersonalDataRepository personalDataRepository;

		public PersonalDataService(IPersonalDataRepository personalDataRepo)
		{
			personalDataRepository = personalDataRepo;
		}

		public int Put(PersonalData personalData)
		{
			return personalDataRepository.Put(personalData);
		}

		public IEnumerable<PersonalData> GetAll()
		{
			return personalDataRepository.GetAll();
		}

		public PersonalData GetByUserId(int userId)
		{
			return personalDataRepository.GetByUserId(userId);
		}

		public PersonalData GetById(int id)
		{
			return personalDataRepository.GetById(id);
		}

		public int Update(PersonalData personalData)
		{
			return personalDataRepository.Update(personalData);
		}

		public int DeleteById(int id)
		{
			return personalDataRepository.DeleteById(id);
		}
	}
}