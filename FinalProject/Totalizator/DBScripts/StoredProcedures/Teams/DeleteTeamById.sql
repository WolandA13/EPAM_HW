CREATE PROCEDURE [sp_DeleteTeamById]
	@id INT
AS
	DELETE FROM [Teams] WHERE [Id] = @id
GO