CREATE PROCEDURE [sp_UpdateSportEvent]
	@id INT,
	@date DATETIME, 
	@sportId INT
AS
	UPDATE [SportEvents] 
	SET [Date] = @date, [SportId] = @sportId 
	WHERE [Id] = @id
GO