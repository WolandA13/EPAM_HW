CREATE PROCEDURE [sp_DeletePersonalDataById]
	@id INT
AS
	DELETE FROM [PersonalData] WHERE [Id] = @id
GO
