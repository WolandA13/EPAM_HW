using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Data.Repositories.Realizations
{
	public class UserRepository : IUserRepository
	{
		private readonly string connectionString;

		public UserRepository(string connection)
		{
			connectionString = connection;
		}

		public int Put(User user)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				
				string sqlExpression = "sp_InsertUser";

				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@email", user.Email);
				command.Parameters.AddWithValue("@password", user.Password);
				
				return (int)command.ExecuteScalar();
			}
		}

		public IEnumerable<User> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				
				string sqlExpression = "sp_SelectAllUsers";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

				using (var reader = command.ExecuteReader())
				{
					var users = new List<User>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var user = new User()
							{
								Id = (int)reader["Id"],
								Email = (string)reader["Email"],
								Password = (string)reader["Password"]
							};
							users.Add(user);
						}
					}
					return users;
				}
			}
		}

		public User GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectUserById";
				
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@id", id);

				using (var reader = command.ExecuteReader())
				{
					if (reader.HasRows)
					{
						reader.Read();

						var user = new User()
						{
							Id = (int)reader["Id"],
							Email = (string)reader["Email"],
							Password = (string)reader["Password"]
						};
						return user;
					}
					return null;
				}
			}
		}

		public int Update(User user)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_UpdateUser";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@id", user.Id);
				command.Parameters.AddWithValue("@email", user.Email);
				command.Parameters.AddWithValue("@password", user.Password);

				return (int)command.ExecuteScalar();
			}
		}

		public int DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_DeleteUserById";
				
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@id", id);

				return (int)command.ExecuteScalar();
			}
		}
	}
}