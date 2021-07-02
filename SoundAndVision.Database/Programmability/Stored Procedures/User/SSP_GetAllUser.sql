CREATE PROCEDURE [dbo].[SSP_GetAllUser]
AS
BEGIN
	SELECT * FROM [dbo].[V_UserInfo];
END;