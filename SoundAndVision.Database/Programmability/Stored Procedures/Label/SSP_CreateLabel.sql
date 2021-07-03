CREATE PROCEDURE [dbo].[SSP_CreateLabel]
	@Name NVARCHAR(100),
	@Picture NVARCHAR(MAX),
	@Location NVARCHAR(50),
	@FoundationYear SMALLINT
AS
BEGIN
	BEGIN TRY
		INSERT INTO [dbo].[Label]([Name], [Picture], [Location], [FoundationYear])
			VALUES (@Name, ISNULL(@Picture, [dbo].[SSF_SetDefaultAvatar]()), @Location, @FoundationYear)

		RETURN 0
	END TRY
	BEGIN CATCH
		THROW 51000, N'Label could not be added!', 1;
	END CATCH
END;