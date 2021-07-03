CREATE VIEW [dbo].[V_AlbumArtist]
	AS
	SELECT AL.[Id], AL.[Name], AR.[Id] AS 'ArtistId', AR.[Name] AS 'ArtistName', AR.[Picture] AS 'ArtistPicture', AR.[Alias] AS 'ArtistAlias', 
			AR.[StartDate] AS 'ArtistStartDate', AR.[EndDate] AS 'ArtistEndDate', AR.[Description] AS 'ArtistDescription'
	FROM [dbo].[Album] AS AL
	LEFT JOIN [dbo].[AlbumArtist] AS ALAR
		ON AL.[Id] = ALAR.[AlbumId]
	LEFT JOIN [dbo].[Artist] AS AR
		ON ALAR.[ArtistId] = AR.[Id];