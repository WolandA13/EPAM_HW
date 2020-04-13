using System.Collections.Generic;
using System.Data.SqlClient;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Data.Models;

namespace Totalizator.Data.Repositories.Realizations
{
	public class ContactInformationRepository : IContactInformationRepository
	{
		private readonly string connectionString;

		public ContactInformationRepository(string connection)
		{
			connectionString = connection;
		}

		public int Put(ContactInformation contactInformation)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = $"sp_InsertContactInformation";
				
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@phoneNumber", contactInformation.PhoneNumber);
				command.Parameters.AddWithValue("@personalDataId", contactInformation.PersonalDataId);

				return (int)command.ExecuteScalar();
			}
		}

		public ContactInformation GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectContactInformationById";

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

		public IEnumerable<ContactInformation> GetByPersonalDataId(int personalDataId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectContactInformationByPersonalDataId";

				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@personalDataId", personalDataId);

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

		public IEnumerable<ContactInformation> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_SelectAllContactInformation";
				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};

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

		public int Update(ContactInformation contactInformation)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_UpdateContactInformation";

				var command = new SqlCommand(sqlExpression, connection)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				command.Parameters.AddWithValue("@phoneNumber", contactInformation.PhoneNumber);
				command.Parameters.AddWithValue("@personalDataId", contactInformation.PersonalDataId);

				return (int)command.ExecuteScalar();
			}
		}

		public int DeleteById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string sqlExpression = "sp_DeleteContactInformationById";

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
