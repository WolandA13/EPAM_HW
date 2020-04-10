CREATE PROCEDURE [sp_UpdateBet]
	@id INT,
	@registrationDate DATETIME, 
	@sportEventId INT,
	@userId INT
AS
	UPDATE [Bets] 
	SET [RegistrationDate] = @registrationDate, 
		[SportEventId] = @sportEventId, 
		[UserId] = @userId
	WHERE [Id] = @id
GO
