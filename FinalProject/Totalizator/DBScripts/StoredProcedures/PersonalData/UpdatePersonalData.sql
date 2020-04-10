CREATE PROCEDURE [sp_UpdatePersonalData]
	@id INT,
	@firstName NVARCHAR(20),
	@patronymic NVARCHAR(20),
 	@lastName NVARCHAR(20),
	@userId INT
AS
	UPDATE [PersonalData] 
	SET [FirstName] = @firstName, 
		[Patronymic] = @patronymic, 
		[LastName] = @lastName, 
		[UserId] = userId
	WHERE [Id] = @id
GO
