CREATE TABLE [dbo].[Album]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(250) NOT NULL,
	[Cover] VARBINARY(MAX),
	[ReleaseDate] DATE,
	[Description] NVARCHAR(4000),
	[LabelId] INT,
	[AlbumTypeId] INT NOT NULL,
	
	CONSTRAINT [PK_Album] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Album_Label_LabelId] FOREIGN KEY ([LabelId]) 
		REFERENCES [dbo].[Label]([Id]),
	CONSTRAINT [FK_Album_AlbumType_AlbumTypeId] FOREIGN KEY ([AlbumTypeId]) 
		REFERENCES [dbo].[AlbumType]([Id])
);