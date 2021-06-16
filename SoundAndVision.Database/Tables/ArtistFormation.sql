CREATE TABLE [dbo].[ArtistFormation]
(
	[BandId] INT NOT NULL,
	[ArtistId] INT NOT NULL,
	[Role] NVARCHAR(100) NOT NULL,
	[JoiningYear] SMALLINT NOT NULL,
	[LeavingYear] SMALLINT,

	CONSTRAINT [PK_ArtistFormation] PRIMARY KEY (BandId, ArtistId, JoiningYear),
	CONSTRAINT [CK_Band_Artist] CHECK (BandId != ArtistId),
	CONSTRAINT [FK_ArtistFormation_Artist_BandId] FOREIGN KEY ([BandId])
		REFERENCES [dbo].[Artist]([Id]),
	CONSTRAINT [FK_ArtistFormation_Artist_ArtistId] FOREIGN KEY ([ArtistId])
		REFERENCES [dbo].[Artist]([Id])
);