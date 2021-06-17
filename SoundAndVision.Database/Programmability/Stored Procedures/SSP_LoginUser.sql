CREATE PROCEDURE [dbo].[SSP_LoginUser]
	@Email NVARCHAR(384),
	@Password NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		DECLARE @Salt NVARCHAR(100);
		SELECT @Salt = [Salt] FROM [dbo].[User] WHERE [Email] = @Email;

		IF @Salt IS NOT NULL
		BEGIN
			DECLARE @Key NVARCHAR(2048);
			SET @Key = [dbo].[SSF_GetSecretKey]();

			DECLARE @PasswordHash BINARY(64);
			SET @PasswordHash = HASHBYTES('SHA2_512', CONCAT(@Salt, @Key, @Password, @Salt));

			SELECT [Id], [Username], [Email], [RoleId]
			FROM [dbo].[User]
			WHERE [Email] = @Email
				AND [Password] = @PasswordHash;
		END;

		RETURN 0;
	END TRY
	BEGIN CATCH
		THROW 51000, N'User could not be signed in!', 1;
	END CATCH
END;