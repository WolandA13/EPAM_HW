using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class UserService : IUserService
	{
		private readonly IUserRepository userRepository;

		public UserService(IUserRepository repo)
		{
			userRepository = repo;
		}

		public int Put(User user)
		{
			return userRepository.Put(user);
		}

		public IEnumerable<User> GetAll()
		{
			return userRepository.GetAll();
		}

		public User GetById(int id)
		{
			return userRepository.GetById(id);
		}

		public int Update(User user)
		{
			return userRepository.Update(user);
		}

		public int DeleteById(int id)
		{
			return userRepository.DeleteById(id);
		}
	}
}
