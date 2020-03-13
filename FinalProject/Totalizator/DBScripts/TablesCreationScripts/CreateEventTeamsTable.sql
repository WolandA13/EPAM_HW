USE [TotalizatorDB];

GO

CREATE TABLE [EventTeams]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[EventId] INT REFERENCES [Events] ([Id]) NOT NULL,
	[TeamId] INT REFERENCES [Teams] ([Id]) NOT NULL
);

GO