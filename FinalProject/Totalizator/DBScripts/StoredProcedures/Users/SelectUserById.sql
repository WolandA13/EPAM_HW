CREATE PROCEDURE [sp_SelectUserById]
	@id INT
AS
	SELECT * FROM [Users] WHERE [Id] = @id 
GO
