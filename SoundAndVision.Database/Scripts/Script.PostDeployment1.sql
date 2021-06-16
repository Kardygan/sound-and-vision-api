/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [dbo].[AlbumType]([Name]) VALUES
    ('Studio'),
    ('Live'),
    ('EP'),
    ('Single'),
    ('Mixtape'),
    ('Compilation');
GO

INSERT INTO [dbo].[Genre]([Name]) VALUES
    ('Ambient'),
    ('Blues'),
    ('Classical Music'),
    ('Comedy'),
    ('Country'),
    ('Dance'),
    ('Electronic'),
    ('Experimental'),
    ('Folk'),
    ('Hip-Hop'),
    ('Industrial Music'),
    ('Jazz'),
    ('Metal'),
    ('Pop'),
    ('Psychedelia'),
    ('Punk'),
    ('R&B'),
    ('Rock'),
    ('Ska');
GO

INSERT INTO [dbo].[Label]([Name], [Location], [FoundationYear]) VALUES
    ('RCA Victor', 'États-Unis', 1929),
    ('RCA Records', 'États-Unis', 1945),
    ('EMI Records', 'Royaume-Uni', 1931),
    ('Virgin Records', 'Royaume-Uni', 1973),
    ('Parlophone', 'Allemagne', 1896),
    ('Columbia Records', 'États-Unis', 1888);
GO

INSERT INTO [dbo].[Artist]([Name], [StartDate]) VALUES
    ('David Bowie', '1947-01-08'),
    ('Risitas', '1952-12-19');
GO

INSERT INTO [dbo].[Album]([Name], [LabelId], [AlbumTypeId]) VALUES
    ('Ziggy Stardust', 1, 1),
    ('Aladdin Sane', 1, 1);
GO

INSERT INTO [dbo].[AlbumArtist]([AlbumId], [ArtistId]) VALUES
    (1, 1),
    (1, 2),
    (2, 1);
GO

INSERT INTO [dbo].[AlbumGenre]([AlbumId], [GenreId]) VALUES
    (1, 18),
    (1, 9),
    (2, 18),
    (2, 12);
GO