CREATE PROCEDURE [sp_UpdateUser]
	@id INT,
	@email VARCHAR(30),
	@password VARCHAR(30)
AS
	UPDATE [Users] 
	SET [Email] = @email, [Password] = @password 
	WHERE [Id] = @id
GO
