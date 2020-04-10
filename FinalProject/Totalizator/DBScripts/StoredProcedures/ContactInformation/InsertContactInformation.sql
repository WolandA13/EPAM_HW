CREATE PROCEDURE [sp_InsertContactInformation]
	@phoneNumber VARCHAR(30),
	@personalDataId INT
AS
	INSERT INTO [ContactInformation] ([PhoneNumber], [PersonalDataId]) VALUES (@phoneNumber, @personalDataId)
GO