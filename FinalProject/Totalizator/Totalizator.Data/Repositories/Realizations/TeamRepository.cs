using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Data.Models;

namespace Totalizator.Data.Repositories.Realizations
{
	public class TeamRepository : ITeamRepository
	{
		private readonly string connectionString;

		public TeamRepository(string connection)
		{
			connectionString = connection;
		}

		public int Put(Team team)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sqlExpression = "sp_InsertTeam";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

				command.Parameters.AddWithValue("@name", team.Name);
				command.Parameters.AddWithValue("@country", team.Country);

				return (int)command.ExecuteScalar();
			}
		}

		public IEnumerable<Team> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectAllTeams";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

				using (var reader = command.ExecuteReader())
				{
					var teams = new List<Team>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var team = new Team()
							{
								Id = (int)reader["Id"],
								Name = (string)reader["Name"],
								Country = (string)reader["Country"]
							};
							teams.Add(team);
						}
					}
					return teams;
				}
			}
		}

		public Team GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectTeamById";
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

						var team = new Team()
						{
							Id = (int)reader["Id"],
							Name = (string)reader["Name"],
							Country = (string)reader["Country"]
						};
						return team;
					}
					return null;
				}
			}
		}

		public int Update(Team team)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_UpdateTeam";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@id", team.Id);
				command.Parameters.AddWithValue("@name", team.Name);
				command.Parameters.AddWithValue("@country", team.Country);

				return (int)command.ExecuteScalar();
			}
		}

		public int DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_DeleteTeamById";
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
