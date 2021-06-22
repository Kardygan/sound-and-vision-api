CREATE PROCEDURE [dbo].[SSP_CreateUser]
	@Username NVARCHAR(20),
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

	IF EXISTS (SELECT [Username] FROM [dbo].[User] WHERE [Username] = @Username)
		THROW 51000, N'Username is already taken!', 1;

	IF EXISTS (SELECT [Email] FROM [dbo].[User] WHERE [Email] = @Email)
		THROW 51000, N'Email is already taken!', 1;

	IF(LEN(@Password) >= 8)
	BEGIN
		DECLARE @Salt NVARCHAR(108);
		SET @Salt = CONCAT(NEWID(), NEWID(), NEWID());

		DECLARE @PasswordHash BINARY(64);
		SET @PasswordHash = [dbo].[SSF_SaltAndHash](@Password, @Salt);

		INSERT INTO [dbo].[User]([Username], [FirstName], [LastName], [Email], [Password], [Salt], [Picture], [Location], [Bio])
		OUTPUT [inserted].[Id]
			VALUES (@Username, @FirstName, @LastName, @Email, @PasswordHash, @Salt, ISNULL(@Picture, '../Uploads/All/default_avatar.jpg'), @Location, @Bio);
	END;
	ELSE
		THROW 51000, N'Password is too short!', 1;
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END;