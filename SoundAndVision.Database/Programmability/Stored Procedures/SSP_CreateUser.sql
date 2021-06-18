CREATE PROCEDURE [dbo].[SSP_CreateUser]
	@Username NVARCHAR(30),
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(384),
	@Password NVARCHAR(50),
	@Picture NVARCHAR(MAX),
	@Location NVARCHAR(50),
	@Bio NVARCHAR(4000)
AS
BEGIN
	BEGIN TRY
		SET NOCOUNT ON;

		-- Salt generation.
		DECLARE @Salt NVARCHAR(100);
		SET @Salt = CONCAT(NEWID(), NEWID(), NEWID());

		-- Get secret key with function.
		DECLARE @Key NVARCHAR(2048);
		SET @Key = [dbo].[SSF_GetSecretKey]();

		-- Password hash.
		DECLARE @PasswordHash BINARY(64);
		SET @PasswordHash = HASHBYTES('SHA2_512', CONCAT(@Salt, @Key, @Password, @Salt));

		-- User registration.
		INSERT INTO [dbo].[User]([Username], [FirstName], [LastName], [Email], [Password], [Salt], [Picture], [Location], [Bio])
		OUTPUT [inserted].[Id]
			VALUES (@Username, @FirstName, @LastName, @Email, @PasswordHash, @Salt, ISNULL(@Picture, '../Uploads/All/default_avatar.jpg'), @Location, @Bio);

		RETURN 0;
	END TRY
	BEGIN CATCH
		THROW 51000, N'User could not be registered!', 1;
	END CATCH
END;