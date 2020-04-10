using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class ContactInformationService : IContactInformationService
	{
		private readonly IContactInformationRepository contactInformationRepository;

		public ContactInformationService(IContactInformationRepository contactInfoRepo)
		{
			contactInformationRepository = contactInfoRepo;
		}

		public int Put(ContactInformation contactInformation)
		{
			return contactInformationRepository.Put(contactInformation);
		}

		public ContactInformation GetById(int id)
		{
			return contactInformationRepository.GetById(id);
		}

		public IEnumerable<ContactInformation> GetByPersonalDataId(int personalDataId)
		{
			return contactInformationRepository.GetByPersonalDataId(personalDataId);
		}

		public IEnumerable<ContactInformation> GetAll()
		{
			return contactInformationRepository.GetAll();
		}

		public int Update(ContactInformation contactInformation)
		{
			return contactInformationRepository.Update(contactInformation);
		}

		public int DeleteById(int id)
		{
			return contactInformationRepository.DeleteById(id);
		}
	}
}