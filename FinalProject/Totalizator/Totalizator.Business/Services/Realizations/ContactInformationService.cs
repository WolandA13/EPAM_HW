using AutoMapper;
using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Models;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class ContactInformationService : IContactInformationService
	{
		private readonly IContactInformationRepository contactInformationRepository;
		private readonly IMapper mapper;

		public ContactInformationService(IContactInformationRepository repository)
		{
			contactInformationRepository = repository;
			mapper = new MapperConfiguration(cfg => cfg.CreateMap<ContactInformationViewModel, ContactInformation>()).CreateMapper();
		}

		public int Put(ContactInformationViewModel contactInformationViewModel)
		{
			return contactInformationRepository.Put(mapper.Map<ContactInformationViewModel, ContactInformation>(contactInformationViewModel));
		}

		public ContactInformationViewModel GetById(int id)
		{
			return mapper.Map<ContactInformation, ContactInformationViewModel>(contactInformationRepository.GetById(id));
		}

		public IEnumerable<ContactInformationViewModel> GetByPersonalDataId(int personalDataId)
		{
			return mapper.Map<IEnumerable<ContactInformation>, IEnumerable<ContactInformationViewModel>>(contactInformationRepository.GetByPersonalDataId(personalDataId));
		}

		public IEnumerable<ContactInformationViewModel> GetAll()
		{
			return mapper.Map<IEnumerable<ContactInformation>, IEnumerable<ContactInformationViewModel>>(contactInformationRepository.GetAll());
		}

		public int Update(ContactInformationViewModel contactInformationViewModel)
		{
			return contactInformationRepository.Update(mapper.Map<ContactInformationViewModel, ContactInformation>(contactInformationViewModel));
		}

		public int DeleteById(int id)
		{
			return contactInformationRepository.DeleteById(id);
		}
	}
}