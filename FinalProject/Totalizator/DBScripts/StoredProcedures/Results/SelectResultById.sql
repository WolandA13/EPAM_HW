CREATE PROCEDURE [sp_SelectResultById]
	@id INT
AS
	SELECT * FROM [Results] WHERE [Id] = @id 
GO
