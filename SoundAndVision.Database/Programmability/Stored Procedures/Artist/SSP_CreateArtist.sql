CREATE PROCEDURE [dbo].[SSP_CreateArtist]
	@Name NVARCHAR(100),
	@Picture NVARCHAR(MAX),
	@Alias NVARCHAR(300),
	@StartDate DATE,
	@EndDate DATE,
	@Description NVARCHAR(4000)
AS
BEGIN
	BEGIN TRY
		INSERT INTO [dbo].[Artist]([Name], [Picture], [Alias], [StartDate], [EndDate], [Description])
			VALUES (@Name, ISNULL(@Picture, [dbo].[SSF_SetDefaultAvatar]()), @Alias, @StartDate, @EndDate, @Description);
	END TRY
	BEGIN CATCH
		THROW 51000, N'Artist could not be added!', 1;
	END CATCH
END;