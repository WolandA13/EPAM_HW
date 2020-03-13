USE [TotalizatorDB];

GO

CREATE TABLE [Bets]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[DateOfRegistration] DATETIME NOT NULL,
	[BetInformationId] INT REFERENCES [BetsInformation] (Id) UNIQUE NOT NULL,
	[UserId] INT REFERENCES [Users] ([Id]) NOT NULL
);

GO