CREATE PROCEDURE [dbo].[SSP_SetContributorRole]
	@Id int
AS
BEGIN
	UPDATE [dbo].[User]
	SET [RoleId] = 3
	WHERE [Id] = @Id;
END;