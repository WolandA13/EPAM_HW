using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Shared.Realization;

namespace Totalizator.Data.Repositories
{
	public class ContactInformationRepository
	{
		private readonly string connectionString = @"Data Source=WOLAND-A\MSSQLSERVER01;Initial Catalog=TotalizatorDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		public void Put(ContactInformation contactInformation)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"INSERT INTO [ContactInformation] ([PhoneNumber], [PersonalDataId]) VALUES ('{contactInformation.PhoneNumber}', {contactInformation.PersonalDataId})";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public ContactInformation GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"SELECT * FROM [ContactInformation] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);

				using (var reader = command.ExecuteReader())
				{
					if (reader.HasRows)
					{
						reader.Read();

						var contactInformation = new ContactInformation()
						{
							Id = (int)reader["Id"],
							PhoneNumber = (string)reader["PhoneNumber"],
							PersonalDataId = (int)reader["PersonalDataId"]
						};
						return contactInformation;
					}
					return null;
				}
			}
		}

		public List<ContactInformation> GetByPersonalDataId(int personalDataId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"SELECT * FROM [ContactInformation] WHERE [PersonalDataId] = {personalDataId}";
				var command = new SqlCommand(sqlExpression, connection);

				using (var reader = command.ExecuteReader())
				{
					var contactInformationList = new List<ContactInformation>();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var contactInformation = new ContactInformation()
							{
								Id = (int)reader["Id"],
								PhoneNumber = (string)reader["PhoneNumber"],
								PersonalDataId = (int)reader["PersonalDataId"]
							};
							contactInformationList.Add(contactInformation);
						}
					}
					return contactInformationList;
				}
			}
		}

		public void Update(ContactInformation contactInformation)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"UPDATE [ContactInformation] SET [PhoneNumber] = {contactInformation.PhoneNumber}, [PersonalDataId] = {contactInformation.PersonalDataId} WHERE [Id] = {contactInformation.Id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}

		public void DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"DELETE FROM [ContactInformation] WHERE [Id] = {id}";
				var command = new SqlCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
			}
		}
	}
}
