CREATE PROCEDURE [dbo].[SSP_GetAllAlbum]
AS
BEGIN
	SELECT * FROM [dbo].[V_AlbumInfo];
END;