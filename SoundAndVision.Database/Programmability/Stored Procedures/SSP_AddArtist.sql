CREATE PROCEDURE [dbo].[SSP_AddArtist]
	@Name NVARCHAR(100),
	@Picture VARBINARY(MAX),
	@Alias NVARCHAR(300),
	@StartDate DATE,
	@EndDate DATE,
	@Description NVARCHAR(4000)
AS
BEGIN
	BEGIN TRY
		INSERT INTO [dbo].[Artist]([Name], [Picture], [Alias], [StartDate], [EndDate], [Description])
			VALUES (@Name, @Picture, @Alias, @StartDate, @EndDate, @Description)

		RETURN 0
	END TRY
	BEGIN CATCH
		THROW 51000, N'Artist could not been added!', 1;
	END CATCH
END;