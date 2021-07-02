CREATE PROCEDURE [dbo].[SSP_SetAdminRole]
	@Id int
AS
BEGIN
	UPDATE [dbo].[User]
	SET [RoleId] = 1
	WHERE [Id] = @Id;
END;