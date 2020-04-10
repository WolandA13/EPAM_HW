CREATE PROCEDURE [sp_SelectBetById]
	@id INT
AS
	SELECT * FROM [Bets] WHERE [Id] = @id 
GO