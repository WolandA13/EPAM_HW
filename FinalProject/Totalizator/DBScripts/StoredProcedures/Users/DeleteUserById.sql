CREATE PROCEDURE [sp_DeleteUserById]
	@id INT
AS
	DELETE FROM [Users] WHERE [Id] = @id
GO
