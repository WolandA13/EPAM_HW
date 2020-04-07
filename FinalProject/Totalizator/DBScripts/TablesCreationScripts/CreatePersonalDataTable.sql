USE [TotalizatorDB];

GO

CREATE TABLE [PersonalData]
(
	[Id] INT PRIMARY KEY IDENTITY,
    [FirstName] NVARCHAR(20) NOT NULL,
	[Patronymic] NVARCHAR(20),
    [LastName] NVARCHAR(20) NOT NULL,
    [UserId] INT REFERENCES [Users] ([Id]) NOT NULL
);

GO