CREATE PROCEDURE [sp_SelectBetByUserId]
	@userId INT
AS
	SELECT * FROM [Bets] WHERE [UserId] = @userId 
GO