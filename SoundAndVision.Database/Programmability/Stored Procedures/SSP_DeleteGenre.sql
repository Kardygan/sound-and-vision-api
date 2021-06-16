CREATE PROCEDURE [dbo].[SSP_DeleteGenre]
	@Id INT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM [dbo].[AlbumGenre]
			WHERE [GenreId] = @Id;

			DELETE FROM [dbo].[Genre]
			WHERE [Id] = @Id;
			
			RETURN 0
			COMMIT;	
		END TRY
		BEGIN CATCH
			ROLLBACK;
			THROW 51000, N'Genre could not been deleted!', 1;
		END CATCH
END;