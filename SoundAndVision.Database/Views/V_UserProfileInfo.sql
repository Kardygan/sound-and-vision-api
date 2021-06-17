CREATE VIEW [dbo].[V_UserProfileInfo]
	AS 
	SELECT [Id], [Username], [FirstName], [LastName], [Email], [Picture], [Location], [Bio], [RegistrationDate], [RoleId]
	FROM [dbo].[User];