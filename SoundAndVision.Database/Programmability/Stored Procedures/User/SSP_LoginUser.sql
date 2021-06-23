CREATE PROCEDURE [dbo].[SSP_LoginUser]
	@Email NVARCHAR(384),
	@Password NVARCHAR(30)
AS
BEGIN
	BEGIN TRY
		DECLARE @Salt NVARCHAR(108);
		SELECT @Salt = [Salt] FROM [dbo].[User] WHERE [Email] = @Email AND [IsActive] = 'TRUE';

		IF (@Salt IS NOT NULL)
		BEGIN
			DECLARE @PasswordHash BINARY(64);
			SET @PasswordHash = [dbo].[SSF_SaltAndHash](@Password, @Salt);

			DECLARE @UserId INT;
			SELECT @UserId = [Id] FROM [dbo].[User] WHERE [Email] = @Email AND [Password] = @PasswordHash;

			IF (@UserId IS NOT NULL)
				EXEC [dbo].[SSP_GetUserById] @UserId;
			ELSE
				THROW 51000, N'The email or password is incorrect!', 1;
		END;
		ELSE
			THROW 51000, N'The email or password is incorrect!', 1;
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END;