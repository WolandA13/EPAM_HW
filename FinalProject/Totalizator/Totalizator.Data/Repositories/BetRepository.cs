using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Shared.Realization;

namespace Totalizator.Data.Repositories
{
	public class BetRepository
	{
		private readonly string connectionString = @"Data Source=WOLAND-A\MSSQLSERVER01;Initial Catalog=TotalizatorDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		public void Put(Bet bet)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"INSERT INTO [Bets] ([RegistrationDate], [SportEventId], [UserId]) VALUES ({bet.RegistrationDate}, {bet.SportEventId}, {bet.UserId})";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public List<Bet> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "SELECT * FROM [Bets]";
				var command = new SqlCommand(sqlExpression, connection);

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
				string sqlExpression = $"SELECT * FROM [Bets] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);

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

		public List<Bet> GetByUserId(int userId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"SELECT * FROM [Bets] WHERE ([UserId]) = {userId}";
				var command = new SqlCommand(sqlExpression, connection);

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

		public void Update(Bet bet)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"UPDATE [Bets] SET [RegistrationDate] = {bet.RegistrationDate}, [SportEventId] = {bet.SportEventId}, [UserId] = {bet.UserId} WHERE [Id] = {bet.Id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public void DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"DELETE FROM [Bets] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}
	}
}
