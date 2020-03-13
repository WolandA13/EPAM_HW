USE [TotalizatorDB];
GO

CREATE TABLE [Users]
(
	[Id] INT PRIMARY KEY IDENTITY,
    [Email] VARCHAR(30) NOT NULL UNIQUE,
	[Password] VARCHAR(30) NOT NULL,
	[PersonalInformationId] INT REFERENCES [PersonalInformation] ([Id]) UNIQUE NOT NULL,
	[RoleId] INT REFERENCES [Roles] ([Id]) NOT NULL
);
GO