USE [TotalizatorDB];
GO

CREATE TABLE [Phones]
(
	[Id] INT PRIMARY KEY IDENTITY,
    [PhoneNumber] VARCHAR(30) UNIQUE,
	[PersonalInformationId] INT REFERENCES [PersonalInformation] ([Id]) ON DELETE CASCADE UNIQUE NOT NULL
);
GO