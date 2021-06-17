CREATE PROCEDURE [dbo].[SSP_CreateGenre]
	@Name NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		INSERT INTO [dbo].[Genre]([Name])
			VALUES (@Name)

		RETURN 0
	END TRY
	BEGIN CATCH
		THROW 51000, N'Genre could not be added!', 1;
	END CATCH
END;