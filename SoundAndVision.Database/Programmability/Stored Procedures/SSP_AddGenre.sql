CREATE PROCEDURE [dbo].[SSP_AddGenre]
	@Name NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		INSERT INTO [dbo].[Genre]([Name])
			VALUES (@Name)

		RETURN 0
	END TRY
	BEGIN CATCH
		THROW 51000, N'Genre could not been added!', 1;
	END CATCH
END;