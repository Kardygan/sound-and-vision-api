CREATE PROCEDURE [dbo].[SSP_CreateTrack]
	@Num NVARCHAR(5),
	@Name NVARCHAR(250),
	@Duration SMALLINT,
	@AlbumId INT
AS
BEGIN
	INSERT INTO [dbo].[Track]([Num], [Name], [Duration], [AlbumId])
		VALUES (@Num, @Name, @Duration, @AlbumId);
END;