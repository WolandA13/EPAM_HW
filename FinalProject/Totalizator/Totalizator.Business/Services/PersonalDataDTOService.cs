using Totalizator.Business.DTO;

namespace Totalizator.Business.Services
{
	public class PersonalDataDTOService
	{
		public PersonalDataDTO GetById(int id)
		{
			var personalDataService = new PersonalDataService();
			var contactInformationService = new ContactInformationService();

			var personalDataDTO = new PersonalDataDTO()
			{
				PersonalData = personalDataService.GetById(id),
				ContactInformationList = contactInformationService.GetByPersonalDataId(id)
			};
			return personalDataDTO;
		}
	}
}
