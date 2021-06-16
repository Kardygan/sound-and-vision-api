CREATE PROCEDURE [dbo].[SSP_AddLabel]
	@Name NVARCHAR(100),
	@Picture VARBINARY(MAX),
	@Location NVARCHAR(50),
	@FoundationYear SMALLINT
AS
BEGIN
	BEGIN TRY
		INSERT INTO [dbo].[Label]([Name], [Picture], [Location], [FoundationYear])
			VALUES (@Name, @Picture, @Location, @FoundationYear)

		RETURN 0
	END TRY
	BEGIN CATCH
		THROW 51000, N'Label could not been added!', 1;
	END CATCH
END;