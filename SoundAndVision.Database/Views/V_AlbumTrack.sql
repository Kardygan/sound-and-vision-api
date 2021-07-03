CREATE VIEW [dbo].[V_AlbumTrack]
	AS 
	SELECT AL.[Id], AL.[Name], TR.[Id] AS 'TrackId', TR.[Num] AS 'TrackNum', TR.[Name] AS 'TrackName', TR.[Duration] AS 'TrackDuration'
	FROM [dbo].[Album] AS AL
	LEFT JOIN [dbo].[Track] AS TR
		ON AL.[Id] = TR.[AlbumId];