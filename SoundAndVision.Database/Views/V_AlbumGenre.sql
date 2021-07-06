CREATE VIEW [dbo].[V_AlbumGenre]
	AS
	SELECT AL.[Id], GE.[Id] AS 'GenreId', GE.[Name] AS 'GenreName'
	FROM [dbo].[Album] AS AL
	LEFT JOIN [dbo].[AlbumGenre] AS ALGE
		ON AL.[Id] = ALGE.[AlbumId]
	LEFT JOIN [dbo].[Genre] AS GE
		ON ALGE.[GenreId] = GE.[Id];