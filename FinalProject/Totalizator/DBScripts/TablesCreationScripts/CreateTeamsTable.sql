USE [TotalizatorDB];

GO

CREATE TABLE [Teams]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	[Country] NVARCHAR(50) NOT NULL
);

GO