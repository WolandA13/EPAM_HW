CREATE PROCEDURE [sp_InsertPersonalData]
	@firstName NVARCHAR(20),
	@patronymic NVARCHAR(20),
 	@lastName NVARCHAR(20),
	@userId INT
AS
	INSERT INTO [PersonalData] ([FirstName], [Patronymic], [LastName], [UserId]) 
	VALUES (@firstName, @patronymic, @lastName, @userId)
GO