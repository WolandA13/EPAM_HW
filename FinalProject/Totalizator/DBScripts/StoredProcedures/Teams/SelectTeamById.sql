CREATE PROCEDURE [sp_SelectTeamById]
	@id INT
AS
	SELECT * FROM [Teams] WHERE [Id] = @id
GO