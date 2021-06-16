-- WORK IN PROGRESS
-- Deleting an artist has a impact on many tables.

CREATE PROCEDURE [dbo].[SSP_DeleteArtist]
	@Id INT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM [dbo].[AlbumArtist]
			WHERE [ArtistId] = @Id;

			DELETE FROM [dbo].[Artist]
			WHERE [Id] = @Id;

			DELETE FROM [dbo].[Album]
			WHERE NOT EXISTS (SELECT 1 FROM [dbo].[AlbumArtist]
								WHERE [AlbumArtist].[AlbumId] = [Album].[Id]);
			
			RETURN 0
			COMMIT;	
		END TRY
		BEGIN CATCH
			ROLLBACK;
			THROW 51000, N'Artist could not been deleted!', 1;
		END CATCH
END;