using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IPersonalDataService
	{
		int Put(PersonalData personalData);

		IEnumerable<PersonalData> GetAll();

		PersonalData GetByUserId(int userId);

		PersonalData GetById(int id);

		int Update(PersonalData personalData);

		int DeleteById(int id);
	}
}
