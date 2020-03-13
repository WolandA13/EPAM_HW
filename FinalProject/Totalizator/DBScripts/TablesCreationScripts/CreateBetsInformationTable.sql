USE [TotalizatorDB];

GO

CREATE TABLE [BetsInformation]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Result] INT NOT NULL,
	[Coefficient] INT NOT NULL,
	[EventId] INT REFERENCES [Events] ([Id]) NOT NULL
);

GO