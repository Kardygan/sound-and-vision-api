CREATE TABLE [dbo].[Artist]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	[Picture] NVARCHAR(MAX),
	[Alias] NVARCHAR(300),
	[StartDate] DATE NOT NULL,
	[EndDate] DATE,
	[Description] NVARCHAR(4000),
	
	CONSTRAINT [PK_Artist] PRIMARY KEY ([Id])
);