using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Data.Models;
using Totalizator.Data.Repositories.Interfaces;

namespace Totalizator.Data.Repositories.Realizations
{
	public class BetRepository : IBetRepository
	{
		private readonly string connectionString;

		public BetRepository(string connection)
		{
			connectionString = connection;
		}

		public int Put(Bet bet)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_InsertBet";

				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@registrationDate", bet.RegistrationDate);
				command.Parameters.AddWithValue("@sportEventId", bet.SportEventId);
				command.Parameters.AddWithValue("@userId", bet.UserId);

				return (int)command.ExecuteScalar();
			}
		}

		public IEnumerable<Bet> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectAllBets";

				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

				using (var reader = command.ExecuteReader())
				{
					var bets = new List<Bet>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var bet = new Bet()
							{
								Id = (int)reader["Id"],
								RegistrationDate = (DateTime)reader["RegistrationDate"],
								SportEventId = (int)reader["SportEventId"],
								UserId = (int)reader["UserId"]
							};
							bets.Add(bet);
						}
					}
					return bets;
				}
			}
		}

		public Bet GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectBetById";

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

						var bet = new Bet()
						{
							Id = (int)reader["Id"],
							RegistrationDate = (DateTime)reader["RegistrationDate"],
							SportEventId = (int)reader["SportEventId"],
							UserId = (int)reader["UserId"]
						};
						return bet;
					}
					return null;
				}
			}
		}

		public IEnumerable<Bet> GetByUserId(int userId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectBetByUserId";

				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@userId", userId);

				using (var reader = command.ExecuteReader())
				{
					var bets = new List<Bet>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var bet = new Bet()
							{
								Id = (int)reader["Id"],
								RegistrationDate = (DateTime)reader["RegistrationDate"],
								SportEventId = (int)reader["SportEventId"],
								UserId = (int)reader["UserId"]
							};
							bets.Add(bet);
						}
					}
					return bets;
				}
			}
		}

		public int Update(Bet bet)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_UpdateBet";

				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@id", bet.Id);
				command.Parameters.AddWithValue("@registrationDate", bet.RegistrationDate);
				command.Parameters.AddWithValue("@sportEventId", bet.SportEventId);
				command.Parameters.AddWithValue("@userId", bet.UserId);

				return (int)command.ExecuteScalar();
			}
		}

		public int DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_DeleteBetById";

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
