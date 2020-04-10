using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Data.Repositories.Interfaces
{
	public interface IContactInformationRepository
	{
		int Put(ContactInformation сontactInformation);

		ContactInformation GetById(int id);

		IEnumerable<ContactInformation> GetByPersonalDataId(int personalDataId);

		IEnumerable<ContactInformation> GetAll();

		int Update(ContactInformation сontactInformation);

		int DeleteById(int id);
	}
}