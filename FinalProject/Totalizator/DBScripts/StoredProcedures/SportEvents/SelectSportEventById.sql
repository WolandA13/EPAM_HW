CREATE PROCEDURE [sp_SelectSportEventById]
	@id INT
AS
	SELECT * FROM [SportEvents] WHERE [Id] = @id 
GO