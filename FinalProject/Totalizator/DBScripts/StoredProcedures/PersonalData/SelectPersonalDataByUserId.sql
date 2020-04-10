CREATE PROCEDURE [sp_SelectPersonalDataByUserId]
	@userId INT
AS
	SELECT * FROM [PersonalData] WHERE [UserId] = @userId 
GO