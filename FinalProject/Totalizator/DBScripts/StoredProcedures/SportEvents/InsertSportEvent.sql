CREATE PROCEDURE [sp_InsertSportEvent]
	@date DATETIME, 
	@sportId INT
AS
	INSERT INTO [SportEvents] ([Date], [SportId]) VALUES (@date, @sportId)
GO