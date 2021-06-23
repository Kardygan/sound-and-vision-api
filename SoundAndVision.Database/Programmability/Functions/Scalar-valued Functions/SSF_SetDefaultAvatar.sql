CREATE FUNCTION [dbo].[SSF_SetDefaultAvatar]()
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @DefaultAvatarPath NVARCHAR(MAX);

	SET @DefaultAvatarPath = N'../Uploads/All/default_avatar.jpg';

	RETURN @DefaultAvatarPath;
END;