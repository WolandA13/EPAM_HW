CREATE PROCEDURE [sp_SelectContactInformationByPersonalDataId]
	@personalDataId INT
AS
	SELECT * FROM [ContactInformation] WHERE [PersonalDataId] = @personalDataId 
GO