CREATE PROCEDURE [dbo].[SSP_UpdateGenre]
	@Name NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		UPDATE [dbo].[Genre]
		SET [Name] = @Name

		RETURN 0
	END TRY
	BEGIN CATCH
		THROW 51000, N'Genre could not been updated!', 1;
	END CATCH
END;