CREATE PROCEDURE [dbo].[SSP_CreateAlbumGenre]
	@AlbumId INT,
	@GenreId INT
AS
BEGIN
	INSERT INTO [dbo].[AlbumGenre]([AlbumId], [GenreId])
		VALUES (@AlbumId, @GenreId);
END;