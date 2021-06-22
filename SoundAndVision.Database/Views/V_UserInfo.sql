CREATE VIEW [dbo].[V_UserInfo]
	AS 
	SELECT [Id], [Username], [FirstName], [LastName], [Email], [Picture], [Location], [Bio], [RegistrationDate], [IsActive], [RoleId]
	FROM [dbo].[User];