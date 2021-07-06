CREATE TABLE [dbo].[Track]
(
	[Id] INT NOT NULL IDENTITY,
	[Num] NVARCHAR(5) NOT NULL,
	[Name] NVARCHAR(250) NOT NULL,
	[Duration] SMALLINT,
	[AlbumId] INT NOT NULL,
	
	CONSTRAINT [PK_Track] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Track_Album_AlbumId] FOREIGN KEY ([AlbumId]) 
		REFERENCES [dbo].[Album]([Id])
);