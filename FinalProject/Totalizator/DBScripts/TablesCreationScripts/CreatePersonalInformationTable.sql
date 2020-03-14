USE [TotalizatorDB];

GO

CREATE TABLE [PersonalInformation]
(
	[Id] INT PRIMARY KEY IDENTITY REFERENCES [Users] ([Id]) ON DELETE CASCADE,
    [FirstName] NVARCHAR(20) NOT NULL,
	[MidName] NVARCHAR(20),
    [LastName] NVARCHAR(20) NOT NULL
);

GO