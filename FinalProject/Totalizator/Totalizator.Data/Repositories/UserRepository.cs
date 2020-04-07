using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Shared.Realization;

namespace Totalizator.Data.Repositories
{
	public class UserRepository
	{
		private readonly string connectionString = @"Data Source=WOLAND-A\MSSQLSERVER01;Initial Catalog=TotalizatorDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		public void Put(User user)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"INSERT INTO [Users] ([Email], [Password]) VALUES ('{user.Email}', '{user.Password}')";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public List<User> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "SELECT * FROM [Users]";
				var command = new SqlCommand(sqlExpression, connection);
				
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
				string sqlExpression = $"SELECT * FROM [Users] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);

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

		public void Update(User user)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"UPDATE [Users] SET [Email] = {user.Email}, [Password] = {user.Password} WHERE [Id] = {user.Id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public void DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"DELETE FROM [Users] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}
	}
}