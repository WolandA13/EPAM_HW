CREATE PROCEDURE [sp_SelectContactInformationById]
	@id INT
AS
	SELECT * FROM [ContactInformation] WHERE [Id] = @id 
GO