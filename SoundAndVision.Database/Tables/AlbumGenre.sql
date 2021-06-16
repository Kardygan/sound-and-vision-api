CREATE TABLE [dbo].[AlbumGenre]
(
	[AlbumId] INT NOT NULL,
	[GenreId] INT NOT NULL,
	
	CONSTRAINT [PK_AlbumGenre] PRIMARY KEY ([AlbumId], [GenreId]),
	CONSTRAINT [FK_AlbumGenre_Album_AlbumId] FOREIGN KEY ([AlbumId]) 
		REFERENCES [dbo].[Album]([Id]),
	CONSTRAINT [FK_AlbumGenre_Genre_GenreId] FOREIGN KEY ([GenreId]) 
		REFERENCES [dbo].[Genre]([Id])
);