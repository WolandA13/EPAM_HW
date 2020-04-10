CREATE PROCEDURE [sp_InsertUser]
	@email VARCHAR(30), 
	@password VARCHAR(30)
AS
	INSERT INTO [Users] ([Email], [Password]) VALUES (@email, @password)
GO