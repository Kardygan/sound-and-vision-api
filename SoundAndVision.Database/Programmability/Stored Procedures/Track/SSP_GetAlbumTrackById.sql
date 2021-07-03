CREATE PROCEDURE [dbo].[SSP_GetAlbumTrackById]
	@Id INT
AS
BEGIN
	SELECT * FROM [dbo].[V_AlbumTrack] WHERE [Id] = @Id;
END;