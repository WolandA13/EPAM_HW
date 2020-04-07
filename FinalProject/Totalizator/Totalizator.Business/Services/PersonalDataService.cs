using System.Collections.Generic;
using Totalizator.Data.Repositories;
using Totalizator.Shared.Realization;

namespace Totalizator.Business.Services
{
	class PersonalDataService
	{
		private readonly PersonalDataRepository personalDataRepository;

		public PersonalDataService()
		{
			personalDataRepository = new PersonalDataRepository();
		}

		public void Put(PersonalData personalData)
		{
			personalDataRepository.Put(personalData);
		}

		public List<PersonalData> GetAll()
		{
			return personalDataRepository.GetAll();
		}

		public PersonalData GetById(int id)
		{
			return personalDataRepository.GetById(id);
		}

		public void Update(PersonalData personalData)
		{
			personalDataRepository.Update(personalData);
		}

		public void DeleteById(int id)
		{
			personalDataRepository.DeleteById(id);
		}
	}
}