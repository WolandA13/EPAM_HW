CREATE PROCEDURE [sp_UpdateTeam]
    @id INT,
	@name NVARCHAR(100),
	@country NVARCHAR(50)
AS
    UPDATE [Teams] SET [Name] = @name, [Country] = @country WHERE [Id] = @id
GO