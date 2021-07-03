CREATE VIEW [dbo].[V_AlbumInfo]
	AS 
	SELECT AL.[Id], AL.[Name], [Cover], [ReleaseDate], [Description], 
			[LabelId], LA.[Name] AS 'LabelName', LA.[Picture] AS 'LabelPicture', LA.[Location] AS 'LabelLocation', LA.[FoundationYear] AS 'LabelFoundationYear', 
			[AlbumTypeId], ALTY.[Name] AS 'AlbumTypeName'
	FROM [dbo].[Album] AS AL
	LEFT JOIN [dbo].[Label] AS LA
		ON AL.[LabelId] = LA.[Id]
	LEFT JOIN [dbo].[AlbumType] AS ALTY
		ON AL.[AlbumTypeId] = ALTY.[Id];