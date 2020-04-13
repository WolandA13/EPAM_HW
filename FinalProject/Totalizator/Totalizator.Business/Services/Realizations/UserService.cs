using AutoMapper;
using System.Collections.Generic;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Data.Models;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Business.Services.Realizations
{
	public class UserService : IUserService
	{
		private readonly IUserRepository userRepository;
		private readonly IMapper mapper;

		public UserService(IUserRepository repo)
		{
			userRepository = repo;
			mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, User>()).CreateMapper();
		}

		public int Put(UserViewModel userViewModel)
		{
			return userRepository.Put(mapper.Map<UserViewModel, User>(userViewModel));
		}

		public IEnumerable<UserViewModel> GetAll()
		{
			return mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(userRepository.GetAll());
		}

		public UserViewModel GetById(int id)
		{
			return mapper.Map<User, UserViewModel>(userRepository.GetById(id));
		}

		public int Update(UserViewModel userViewModel)
		{
			return userRepository.Update(mapper.Map<UserViewModel, User>(userViewModel));
		}

		public int DeleteById(int id)
		{
			return userRepository.DeleteById(id);
		}
	}
}
