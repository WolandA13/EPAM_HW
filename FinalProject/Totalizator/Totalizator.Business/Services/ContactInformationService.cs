using System.Collections.Generic;
using Totalizator.Data.Repositories;
using Totalizator.Shared.Realization;

namespace Totalizator.Business.Services
{
	class ContactInformationService
	{
		private readonly ContactInformationRepository contactInformationRepository;

		public ContactInformationService()
		{
			contactInformationRepository = new ContactInformationRepository();
		}

		public void Put(ContactInformation contactInformation)
		{
			contactInformationRepository.Put(contactInformation);
		}

		public ContactInformation GetById(int id)
		{
			return contactInformationRepository.GetById(id);
		}

		public List<ContactInformation> GetByPersonalDataId(int personalDataId)
		{
			return contactInformationRepository.GetByPersonalDataId(personalDataId);
		}

		public void Update(ContactInformation contactInformation)
		{
			contactInformationRepository.Update(contactInformation);
		}

		public void DeleteById(int id)
		{
			contactInformationRepository.DeleteById(id);
		}
	}
}
