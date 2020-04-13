using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Data.Models;

namespace Totalizator.Data.Repositories.Realizations
{
	public class SportEventRepository : ISportEventRepository
	{
		private readonly string connectionString;

		public SportEventRepository(string connection)
		{
			connectionString = connection;
		}

		public int Put(SportEvent sportEvent)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_InsertSportEvent";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

				command.Parameters.AddWithValue("@date", sportEvent.Date);
				command.Parameters.AddWithValue("@sportId", sportEvent.SportId);

				return (int)command.ExecuteScalar();
			}
		}

		public IEnumerable<SportEvent> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectAllSportEvents";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

				using (var reader = command.ExecuteReader())
				{
					var sportEvents = new List<SportEvent>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var sportEvent = new SportEvent()
							{
								Id = (int)reader["Id"],
								Date = (DateTime)reader["Date"],
								SportId = (int)reader["SportId"]
							};
							sportEvents.Add(sportEvent);
						}
					}
					return sportEvents;
				}
			}
		}

		public IEnumerable<SportEvent> GetBySportId(int sportId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectSportEventsBySportId";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@sportId", sportId);

				using (var reader = command.ExecuteReader())
				{
					var sportEvents = new List<SportEvent>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var sportEvent = new SportEvent()
							{
								Id = (int)reader["Id"],
								Date = (DateTime)reader["Date"],
								SportId = (int)reader["SportId"]
							};
							sportEvents.Add(sportEvent);
						}
					}
					return sportEvents;
				}
			}
		}

		public SportEvent GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectSportEventById";
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

						var sportEvent = new SportEvent()
						{
							Id = (int)reader["Id"],
							Date = (DateTime)reader["Date"],
							SportId = (int)reader["SportId"]
						};
						return sportEvent;
					}
					return null;
				}
			}
		}

		public int Update(SportEvent sportEvent)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_UpdateSportEvent";
				
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@id", sportEvent.Id);
				command.Parameters.AddWithValue("@Date", sportEvent.Date);
				command.Parameters.AddWithValue("@SportId", sportEvent.SportId);

				return (int)command.ExecuteScalar();
			}
		}

		public int DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_DeleteSportEventById";
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
