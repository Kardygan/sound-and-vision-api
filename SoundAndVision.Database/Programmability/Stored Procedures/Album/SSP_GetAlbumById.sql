CREATE PROCEDURE [dbo].[SSP_GetAlbumById]
	@Id INT
AS
BEGIN
	SELECT * FROM [dbo].[V_AlbumInfo] WHERE [Id] = @Id;
END;