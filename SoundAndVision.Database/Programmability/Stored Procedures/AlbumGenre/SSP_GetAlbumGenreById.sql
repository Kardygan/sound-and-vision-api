CREATE PROCEDURE [dbo].[SSP_GetAlbumGenreById]
	@Id INT
AS
BEGIN
	SELECT * FROM [dbo].[V_AlbumGenre] WHERE [Id] = @Id;
END;