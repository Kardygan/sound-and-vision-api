CREATE PROCEDURE [dbo].[SSP_UpdateArtist]
	@Id INT,
	@Name NVARCHAR(100),
	@Picture NVARCHAR(MAX),
	@Alias NVARCHAR(300),
	@StartDate DATE,
	@EndDate DATE,
	@Description NVARCHAR(4000)
AS
BEGIN
	BEGIN TRY
		UPDATE [dbo].[Artist]
		SET [Name] = @Name, [Picture] = @Picture, [Alias] = @Alias, [StartDate] = @StartDate, [EndDate] = @EndDate, [Description] = @Description
		WHERE [Id] = @Id;
	END TRY
	BEGIN CATCH
		THROW 51000, N'Artist could not be updated!', 1;
	END CATCH
END;