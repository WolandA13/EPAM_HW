using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Shared.Realization;

namespace Totalizator.Data.Repositories
{
	public class PersonalDataRepository
	{
		private readonly string connectionString = @"Data Source=WOLAND-A\MSSQLSERVER01;Initial Catalog=TotalizatorDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		public void Put(PersonalData personalData)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"INSERT INTO [PersonalData] ([FirstName], [Patronymic], [LastName]) VALUES ('{personalData.FirstName}', '{personalData.Patronymic}', '{personalData.LastName}')";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public List<PersonalData> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "SELECT * FROM [PersonalData]";
				var command = new SqlCommand(sqlExpression, connection);

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

		public PersonalData GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"SELECT * FROM [PersonalData] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);

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

		public void Update(PersonalData personalData)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"UPDATE [PersonalData] SET [FirstName] = {personalData.FirstName}, [Patronymic] = {personalData.Patronymic}, [LastName] = {personalData.LastName}, [UserId] = {personalData.UserId} WHERE [Id] = {personalData.Id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public void DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"DELETE FROM [PersonalData] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}
	}
}
