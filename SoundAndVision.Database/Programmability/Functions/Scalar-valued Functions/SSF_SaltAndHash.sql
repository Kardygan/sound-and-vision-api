CREATE FUNCTION [dbo].[SSF_SaltAndHash]
(
	@Password NVARCHAR(30),
	@Salt NVARCHAR(108)
)
RETURNS BINARY(64)
AS
BEGIN
	-- Get secret key with function.
	DECLARE @Key NVARCHAR(2048);
	SET @Key = [dbo].[SSF_GetSecretKey]();

	-- Password hash.
	DECLARE @PasswordHash BINARY(64);
	SET @PasswordHash = HASHBYTES('SHA2_512', CONCAT(@Salt, @Key, @Password, @Salt));

	RETURN @PasswordHash;
END
