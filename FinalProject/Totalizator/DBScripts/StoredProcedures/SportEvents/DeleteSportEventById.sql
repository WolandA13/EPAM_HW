CREATE PROCEDURE [sp_DeleteSportEventById]
	@id INT
AS
	DELETE FROM [SportEvents] WHERE [Id] = @id
GO
