using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IContactInformationService
	{
		int Put(ContactInformationViewModel сontactInformationViewModel);

		ContactInformationViewModel GetById(int id);

		IEnumerable<ContactInformationViewModel> GetByPersonalDataId(int personalDataId);

		IEnumerable<ContactInformationViewModel> GetAll();

		int Update(ContactInformationViewModel сontactInformationViewModel);

		int DeleteById(int id);
	}
}
