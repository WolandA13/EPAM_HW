CREATE PROCEDURE [sp_SelectPersonalDataById]
	@id INT
AS
	SELECT * FROM [PersonalData] WHERE [Id] = @id 
GO
