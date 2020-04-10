using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Data.Repositories.Realizations
{
	public class PersonalDataRepository : IPersonalDataRepository
	{
		private readonly string connectionString;

		public PersonalDataRepository(string connection)
		{
			connectionString = connection;
		}

		public int Put(PersonalData personalData)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sqlExpression = "sp_InsertPersonalData";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@firstName", personalData.FirstName);
				command.Parameters.AddWithValue("@patronymic", personalData.Patronymic);
				command.Parameters.AddWithValue("@lastName", personalData.LastName);
				command.Parameters.AddWithValue("@userId", personalData.UserId);

				return (int)command.ExecuteScalar();
			}
		}

		public IEnumerable<PersonalData> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sqlExpression = "sp_SelectAllPersonalData";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

				using (var reader = command.ExecuteReader())
				{
					var personalDataList = new List<PersonalData>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var personalData = new PersonalData()
							{
								Id = (int)reader["Id"],
								FirstName = (string)reader["FirstName"],
								Patronymic = (string)reader["Patronymic"],
								LastName = (string)reader["LastName"],
								UserId = (int)reader["UserId"]
							};
							personalDataList.Add(personalData);
						}
					}
					return personalDataList;
				}
			}
		}

		public PersonalData GetByUserId(int userId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sqlExpression = "sp_SelectPersonalDataByUserId";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@userId", userId);

				using (var reader = command.ExecuteReader())
				{
					if (reader.HasRows)
					{
						reader.Read();

						var userPersonalInformation = new PersonalData()
						{
							Id = (int)reader["Id"],
							FirstName = (string)reader["FirstName"],
							Patronymic = (string)reader["Patronymic"],
							LastName = (string)reader["LastName"],
							UserId = (int)reader["UserId"]
						};
						return userPersonalInformation;
					}
					return null;
				}
			}
		}

		public PersonalData GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sqlExpression = "sp_SelectPersonalDataById";
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

						var userPersonalInformation = new PersonalData()
						{
							Id = (int)reader["Id"],
							FirstName = (string)reader["FirstName"],
							Patronymic = (string)reader["Patronymic"],
							LastName = (string)reader["LastName"],
							UserId = (int)reader["UserId"]
						};
						return userPersonalInformation;
					}
					return null;
				}
			}
		}

		public int Update(PersonalData personalData)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_UpdatePersonalData";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@id", personalData.Id);
				command.Parameters.AddWithValue("@firstName", personalData.FirstName);
				command.Parameters.AddWithValue("@patronymic", personalData.Patronymic);
				command.Parameters.AddWithValue("@lastName", personalData.LastName);
				command.Parameters.AddWithValue("@userId", personalData.UserId);

				return (int)command.ExecuteScalar();
			}
		}

		public int DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_DeletePersonalDataById";
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
