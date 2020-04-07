USE [TotalizatorDB];

GO

CREATE TABLE [SportEventTeams]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[SportEventId] INT REFERENCES [SportEvents] ([Id]) NOT NULL,
	[TeamId] INT REFERENCES [Teams] ([Id]) NOT NULL
);

GO