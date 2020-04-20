CREATE PROCEDURE [sp_InsertResult]
	@name NVARCHAR(50), 
	@coefficient DECIMAL,
	@sportEventId INT
AS
	INSERT INTO [Results] ([Name], [Coefficient], [SportEventId]) VALUES (@name, @coefficient, @sportEventId)
GO