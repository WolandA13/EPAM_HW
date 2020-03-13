USE [TotalizatorDB];

GO

CREATE TABLE [PersonalInformation]
(
	[Id] INT PRIMARY KEY IDENTITY,
    [FirstName] NVARCHAR(20) NOT NULL,
	[MidName] NVARCHAR(20),
    [LastName] NVARCHAR(20) NOT NULL
);

GO