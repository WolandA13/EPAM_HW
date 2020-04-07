USE [TotalizatorDB];

GO

CREATE TABLE [Results]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[ResultTypeId] INT REFERENCES [ResultTypes] ([Id]) NOT NULL,
	[Coefficient] DECIMAL NOT NULL,
	[SportEventId] INT REFERENCES [SportEvents] ([Id]) NOT NULL
);

GO