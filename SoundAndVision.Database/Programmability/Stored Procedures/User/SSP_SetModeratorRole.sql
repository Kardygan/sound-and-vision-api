CREATE PROCEDURE [dbo].[SSP_SetModeratorRole]
	@Id int
AS
BEGIN
	UPDATE [dbo].[User]
	SET [RoleId] = 2
	WHERE [Id] = @Id;
END;