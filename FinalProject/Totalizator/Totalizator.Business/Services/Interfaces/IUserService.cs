using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IUserService
	{
		int Put(User user);

		IEnumerable<User> GetAll();

		User GetById(int id);

		int Update(User user);

		int DeleteById(int id);
	}
}