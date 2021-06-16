CREATE TABLE [dbo].[AlbumArtist]
(
	[AlbumId] INT NOT NULL,
	[ArtistId] INT NOT NULL,
	
	CONSTRAINT [PK_AlbumArtist] PRIMARY KEY ([AlbumId], [ArtistId]),
	CONSTRAINT [FK_AlbumArtist_Album_AlbumId] FOREIGN KEY ([AlbumId]) 
		REFERENCES [dbo].[Album]([Id]),
	CONSTRAINT [FK_AlbumArtist_Artist_ArtistId] FOREIGN KEY ([ArtistId]) 
		REFERENCES [dbo].[Artist]([Id])
);