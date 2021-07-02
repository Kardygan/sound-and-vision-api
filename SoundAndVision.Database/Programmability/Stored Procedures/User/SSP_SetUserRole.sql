CREATE PROCEDURE [dbo].[SSP_SetUserRole]
	@Id int
AS
BEGIN
	UPDATE [dbo].[User]
	SET [RoleId] = 4
	WHERE [Id] = @Id;
END;