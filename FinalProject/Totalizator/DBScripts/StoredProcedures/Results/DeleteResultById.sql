CREATE PROCEDURE [sp_DeleteResultById]
	@id INT
AS
	DELETE FROM [Result] WHERE [Id] = @id
GO
