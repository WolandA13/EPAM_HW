CREATE PROCEDURE [sp_SelectSportEventById]
	@id INT OUT
AS
	SELECT 
		[SportEvents].[Id] AS [Id],
		[SportEvents].[Name] AS [Name],
		[SportEvents].[Date] AS [Date], 	
		[Sports].[Name] AS [SportName]
	FROM [SportEvents]
	LEFT JOIN [Sports] ON [Sports].[Id] = [SportEvents].[SportId]
	WHERE [SportEvents].[Id] = @id
GO