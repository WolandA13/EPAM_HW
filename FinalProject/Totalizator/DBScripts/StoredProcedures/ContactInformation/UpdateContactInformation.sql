CREATE PROCEDURE [sp_UpdateContactInformation]
	@id INT,
	@phoneNumber VARCHAR(30),
	@personalDataId INT
AS
	UPDATE [ContactInformation] 
	SET [PhoneNumber] = @phoneNumber, [PersonalDataId] = @personalDataId 
	WHERE [Id] = @id
GO
