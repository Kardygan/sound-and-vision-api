CREATE PROCEDURE [dbo].[SSP_LoginUser]
	@Email NVARCHAR(384),
	@Password NVARCHAR(30)
AS
BEGIN
	BEGIN TRY
		DECLARE @Salt NVARCHAR(108);
		SELECT @Salt = [Salt] FROM [dbo].[User] WHERE [Email] = @Email AND [IsActive] = 'TRUE';

		IF @Salt IS NOT NULL
		BEGIN
			DECLARE @PasswordHash BINARY(64);
			SET @PasswordHash = [dbo].[SSF_SaltAndHash](@Password, @Salt);

			DECLARE @UserId INT;
			SELECT @UserId = [Id] FROM [dbo].[User] WHERE [Email] = @Email AND [Password] = @PasswordHash;

			SELECT * FROM [dbo].[V_UserInfo] WHERE [Id] = @UserId;
		END;

		RETURN 0;
	END TRY
	BEGIN CATCH
		THROW 51000, N'User could not be signed in!', 1;
	END CATCH
END;