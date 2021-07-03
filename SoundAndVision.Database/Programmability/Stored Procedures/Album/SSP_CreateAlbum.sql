CREATE PROCEDURE [dbo].[SSP_CreateAlbum]
	@Name NVARCHAR(250),
	@Cover NVARCHAR(MAX),
	@ReleaseDate DATE,
	@Description NVARCHAR(4000),
	@LabelId INT,
	@AlbumTypeId INT
AS
BEGIN
	INSERT INTO [dbo].[Album]([Name], [Cover], [ReleaseDate], [Description], [LabelId], [AlbumTypeId])
	OUTPUT [inserted].[Id]
		VALUES (@Name, ISNULL(@Cover, [dbo].[SSF_SetDefaultAvatar]()), @ReleaseDate, @Description, @LabelId, @AlbumTypeId);
END;