CREATE PROCEDURE [sp_InsertTeam]
	@name NVARCHAR(100),
	@country NVARCHAR(50)
AS
	INSERT INTO [Teams] ([Name], [Country]) VALUES (@name, @country)
GO