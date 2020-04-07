USE [TotalizatorDB];

GO

CREATE TABLE [SportEvents]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Date] DATETIME NOT NULL,
	[SportId] INT REFERENCES [Sports] ([Id]) NOT NULL
);

GO