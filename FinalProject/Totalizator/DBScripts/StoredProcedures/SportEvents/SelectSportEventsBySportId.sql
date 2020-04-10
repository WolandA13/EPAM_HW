CREATE PROCEDURE [sp_SelectSportEventsBySportId]
	@sportId INT
AS
	SELECT * FROM [SportEvents] WHERE [SportId] = @sportId
GO
