USE [TotalizatorDB];

GO

CREATE TABLE [Events]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Date] DATETIME NOT NULL,
	[KindOfSportId] INT REFERENCES [KindsOfSport] ([Id]) NOT NULL
);

GO