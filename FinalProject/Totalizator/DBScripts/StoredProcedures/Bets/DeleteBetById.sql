CREATE PROCEDURE [sp_DeleteBetById]
	@id INT
AS
	DELETE FROM [Bets] WHERE [Id] = @id
GO
