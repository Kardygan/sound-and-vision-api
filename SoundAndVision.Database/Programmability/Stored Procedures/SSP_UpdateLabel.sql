CREATE PROCEDURE [dbo].[SSP_UpdateLabel]
	@Name NVARCHAR(100),
	@Picture VARBINARY(MAX),
	@Location NVARCHAR(50),
	@FoundationYear SMALLINT
AS
BEGIN
	BEGIN TRY
		UPDATE [dbo].[Label]
		SET [Name] = @Name, [Picture] = @Picture, [Location] = @Location, [FoundationYear] = @FoundationYear

		RETURN 0
	END TRY
	BEGIN CATCH
		THROW 51000, N'Label could not been updated!', 1;
	END CATCH
END;