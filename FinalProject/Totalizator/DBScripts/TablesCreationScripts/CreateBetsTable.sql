USE [TotalizatorDB];

GO

CREATE TABLE [Bets]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[RegistrationDate] DATETIME NOT NULL,
	[SportEventId] INT REFERENCES [SportEvents] ([Id]) NOT NULL,
	[UserId] INT REFERENCES [Users] ([Id]) NOT NULL
);

GO