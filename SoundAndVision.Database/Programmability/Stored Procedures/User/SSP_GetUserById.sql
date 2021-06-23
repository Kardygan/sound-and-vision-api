CREATE PROCEDURE [dbo].[SSP_GetUserById]
	@Id INT
AS
BEGIN
	SELECT * FROM [dbo].[V_UserInfo] WHERE [Id] = @Id;
END;