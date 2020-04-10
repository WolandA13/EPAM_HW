CREATE PROCEDURE [sp_InsertBet]
	@registrationDate DATETIME, 
	@sportEventId INT,
	@userId INT
AS
	INSERT INTO [Bets] ([RegistrationDate], [SportEventId], [UserId]) 
	VALUES (@registrationDate, @sportEventId, @userId)
GO