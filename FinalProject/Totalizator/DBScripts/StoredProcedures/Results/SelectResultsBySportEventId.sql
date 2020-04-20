CREATE PROCEDURE [sp_SelectResultsBySportEventId]
	@sportEventId INT
AS
	SELECT * FROM [Results] WHERE [SportEventId] = @sportEventId 
GO
