using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IPersonalDataService
	{
		int Put(PersonalDataViewModel personalDataViewModel);

		IEnumerable<PersonalDataViewModel> GetAll();

		PersonalDataViewModel GetByUserId(int userId);

		PersonalDataViewModel GetById(int id);

		int Update(PersonalDataViewModel personalDataViewModel);

		int DeleteById(int id);
	}
}
