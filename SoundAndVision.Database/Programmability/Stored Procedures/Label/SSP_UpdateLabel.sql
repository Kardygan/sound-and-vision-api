CREATE PROCEDURE [dbo].[SSP_UpdateLabel]
	@Id INT,
	@Name NVARCHAR(100),
	@Picture VARBINARY(MAX),
	@Location NVARCHAR(50),
	@FoundationYear SMALLINT
AS
BEGIN
	BEGIN TRY
		UPDATE [dbo].[Label]
		SET [Name] = @Name, [Picture] = @Picture, [Location] = @Location, [FoundationYear] = @FoundationYear
		WHERE [Id] = @Id;
	END TRY
	BEGIN CATCH
		THROW 51000, N'Label could not be updated!', 1;
	END CATCH
END;