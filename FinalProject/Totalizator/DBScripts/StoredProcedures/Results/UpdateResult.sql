CREATE PROCEDURE [sp_UpdateResult]
	@id INT,
	@name NVARCHAR(50), 
	@coefficient DECIMAL,
	@sportEventId INT
AS
	UPDATE [Results] 
	SET [Name] = @name, [Coefficient] = @coefficient, [SportEventId] = @sportEventId
	WHERE [Id] = @id
GO
