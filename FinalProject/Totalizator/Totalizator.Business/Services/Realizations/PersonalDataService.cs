using AutoMapper;
using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Models;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class PersonalDataService : IPersonalDataService
	{
		private readonly IPersonalDataRepository personalDataRepository;
		private readonly IMapper mapper;

		public PersonalDataService(IPersonalDataRepository personalDataRepo)
		{
			personalDataRepository = personalDataRepo;
			mapper = new MapperConfiguration(cfg => cfg.CreateMap<PersonalDataViewModel, PersonalData>()).CreateMapper();
		}

		public int Put(PersonalDataViewModel personalDataViewModel)
		{
			return personalDataRepository.Put(mapper.Map<PersonalDataViewModel, PersonalData>(personalDataViewModel));
		}

		public IEnumerable<PersonalDataViewModel> GetAll()
		{
			return mapper.Map<IEnumerable<PersonalData>, IEnumerable<PersonalDataViewModel>>(personalDataRepository.GetAll());
		}

		public PersonalDataViewModel GetByUserId(int userId)
		{
			return mapper.Map<PersonalData, PersonalDataViewModel>(personalDataRepository.GetByUserId(userId));
		}

		public PersonalDataViewModel GetById(int id)
		{
			return mapper.Map<PersonalData, PersonalDataViewModel>(personalDataRepository.GetById(id));
		}

		public int Update(PersonalDataViewModel personalDataViewModel)
		{
			return personalDataRepository.Update(mapper.Map<PersonalDataViewModel, PersonalData>(personalDataViewModel));
		}

		public int DeleteById(int id)
		{
			return personalDataRepository.DeleteById(id);
		}
	}
}