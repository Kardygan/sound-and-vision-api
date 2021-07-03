CREATE PROCEDURE [dbo].[SSP_GetAlbumArtistById]
	@Id INT
AS
BEGIN
	SELECT * FROM [dbo].[V_AlbumArtist] WHERE [Id] = @Id;
END;