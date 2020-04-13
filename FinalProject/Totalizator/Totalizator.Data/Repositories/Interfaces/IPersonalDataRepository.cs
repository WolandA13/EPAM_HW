using System.Collections.Generic;
using Totalizator.Data.Models;

namespace Totalizator.Data.Repositories.Interfaces
{
	public interface IPersonalDataRepository
	{
		int Put(PersonalData personalData);

		IEnumerable<PersonalData> GetAll();

		PersonalData GetByUserId(int userId);

		PersonalData GetById(int id);

		int Update(PersonalData personalData);

		int DeleteById(int id);
	}
}
