CREATE PROCEDURE [dbo].[SSP_CreateUser]
	@Username NVARCHAR(30),
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(384),
	@Password NVARCHAR(30),
	@Picture NVARCHAR(MAX),
	@Location NVARCHAR(50),
	@Bio NVARCHAR(4000)
AS
BEGIN
	BEGIN TRY
		SET NOCOUNT ON;

		IF(LEN(@Password) >= 8)
		BEGIN
			DECLARE @Salt NVARCHAR(108);
			SET @Salt = CONCAT(NEWID(), NEWID(), NEWID());

			DECLARE @PasswordHash BINARY(64);
			SET @PasswordHash = [dbo].[SSF_SaltAndHash](@Password, @Salt);

			INSERT INTO [dbo].[User]([Username], [FirstName], [LastName], [Email], [Password], [Salt], [Picture], [Location], [Bio])
			OUTPUT [inserted].[Id]
				VALUES (@Username, @FirstName, @LastName, @Email, @PasswordHash, @Salt, ISNULL(@Picture, '../Uploads/All/default_avatar.jpg'), @Location, @Bio);

			RETURN 0;
		END;
	END TRY
	BEGIN CATCH
		THROW 51000, N'User could not be registered!', 1;
	END CATCH
END;