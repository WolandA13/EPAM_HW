using Totalizator.Business.DTO;
using Totalizator.Business.Services.Interfaces;

namespace Totalizator.Business.Services.Realizations
{
	public class PersonalDataDTOService : IPersonalDataDTOService
	{
		private readonly IPersonalDataService personalDataService;
		private readonly IContactInformationService contactInformationService;

		public PersonalDataDTOService(IPersonalDataService personalDataServ, IContactInformationService contactInformServ)
		{
			personalDataService = personalDataServ;
			contactInformationService = contactInformServ;
		}

		public PersonalDataDTO GetById(int id)
		{
			var personalDataDTO = new PersonalDataDTO()
			{
				PersonalData = personalDataService.GetById(id),
				ContactInformationList = contactInformationService.GetByPersonalDataId(id)
			};
			return personalDataDTO;
		}
	}
}
