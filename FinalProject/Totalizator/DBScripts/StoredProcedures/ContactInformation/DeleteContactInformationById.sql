CREATE PROCEDURE [sp_DeleteContactInformationById]
	@id INT
AS
	DELETE FROM [ContactInformation] WHERE [Id] = @id
GO