USE [TotalizatorDB];
GO

CREATE TABLE [ContactInformation]
(
	[Id] INT PRIMARY KEY IDENTITY,
    [PhoneNumber] VARCHAR(30) UNIQUE,
	[PersonalDataId] INT REFERENCES [PersonalData] ([Id]) ON DELETE CASCADE UNIQUE NOT NULL
);
GO