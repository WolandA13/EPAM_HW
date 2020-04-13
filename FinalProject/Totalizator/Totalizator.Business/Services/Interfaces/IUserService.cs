using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IUserService
	{
		int Put(UserViewModel userViewModel);

		IEnumerable<UserViewModel> GetAll();

		UserViewModel GetById(int id);

		int Update(UserViewModel userViewModel);

		int DeleteById(int id);
	}
}