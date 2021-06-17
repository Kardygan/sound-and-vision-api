CREATE PROCEDURE [dbo].[SSP_DeleteLabel]
	@Id INT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM [dbo].[Label]
			WHERE [Id] = @Id;
			
			RETURN 0
			COMMIT;	
		END TRY
		BEGIN CATCH
			ROLLBACK;
			THROW 51000, N'Label could not be deleted!', 1;
		END CATCH
END;