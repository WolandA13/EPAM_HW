using System.Collections.Generic;
using Totalizator.Data.Repositories;
using Totalizator.Shared.Realization;

namespace Totalizator.Business.Services
{
	class UserService
	{
		private readonly UserRepository userRepository;

		public UserService()
		{
			userRepository = new UserRepository();
		}

		public void Put(User user)
		{
			userRepository.Put(user);
		}

		public List<User> GetAll()
		{
			return userRepository.GetAll();
		}

		public User GetById(int id)
		{
			return userRepository.GetById(id);
		}

		public void Update(User user)
		{
			userRepository.Update(user);
		}

		public void DeleteById(int id)
		{
			userRepository.DeleteById(id);
		}
	}
}
