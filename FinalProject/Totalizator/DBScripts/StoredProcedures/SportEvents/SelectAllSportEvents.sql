CREATE PROCEDURE [sp_SelectAllSportEvents]
AS
	SELECT
		[SportEvents].[Id] AS [Id],
		[SportEvents].[Name] AS [Name],
		[SportEvents].[Date] AS [Date], 	
		[Sports].[Name] AS [SportName]
	FROM [SportEvents]
	LEFT JOIN [Sports] ON [Sports].[Id] = [SportEvents].[SportId]
GO