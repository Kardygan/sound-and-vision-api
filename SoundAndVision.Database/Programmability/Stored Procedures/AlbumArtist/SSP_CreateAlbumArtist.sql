CREATE PROCEDURE [dbo].[SSP_CreateAlbumArtist]
	@AlbumId INT,
	@ArtistId INT
AS
BEGIN
	INSERT INTO [dbo].[AlbumArtist]([AlbumId], [ArtistId])
		VALUES (@AlbumId, @ArtistId);
END;