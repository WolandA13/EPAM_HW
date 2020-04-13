﻿using System.Collections.Generic;
using Totalizator.Data.Models;

namespace Totalizator.Data.Repositories.Interfaces
{
	public interface IUserRepository
	{
		int Put(User user);

		IEnumerable<User> GetAll();

		User GetById(int id);

		int Update(User user);

		int DeleteById(int id);
	}
}