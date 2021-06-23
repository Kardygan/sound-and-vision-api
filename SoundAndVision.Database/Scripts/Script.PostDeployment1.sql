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

-- Add main roles.
SET IDENTITY_INSERT [dbo].[UserRole] ON;
INSERT INTO [dbo].[UserRole]([Id], [Name]) VALUES
    (1, 'Admin'),
    (2, 'Moderator'),
    (3, 'Contributor'),
    (4, 'User');

SET IDENTITY_INSERT [dbo].[UserRole] OFF;
GO

-- Add main album types.
INSERT INTO [dbo].[AlbumType]([Name]) VALUES
    ('Studio'),
    ('Live'),
    ('EP'),
    ('Single'),
    ('Mixtape'),
    ('Compilation');
GO

-- Add main genres.
INSERT INTO [dbo].[Genre]([Name]) VALUES
    ('Ambient'),
    ('Dark Ambient'),
    ('Space Ambient'),
    ('Blues'),
    ('Boogie Woogie'),
    ('Soul Blues'),
    ('Classical Music'),
    ('Comedy'),
    ('Country'),
    ('Americana'),
    ('Contemporary Country'),
    ('Country Pop'),
    ('Dance'),
    ('Alternative Dance'),
    ('Dance-Pop'),
    ('Disco'),
    ('Electronic'),
    ('Electropop'),
    ('Glitch'),
    ('Glitch Pop'),
    ('Horror Synth'),
    ('Nightcore'),
    ('Nu Jazz'),
    ('Progressive Electronic'),
    ('Synthpop'),
    ('Synth Punk'),
    ('Synthwave'),
    ('Vapor'),
    ('Wave'),
    ('Witch House'),
    ('Experimental'),
    ('Drone'),
    ('Industrial'),
    ('Noise'),
    ('Turntable Music'),
    ('Folk'),
    ('Contemporary Folk'),
    ('Traditional Folk Music'),
    ('Hip Hop'),
    ('Abstract Hip Hop'),
    ('Afro Trap'),
    ('Bounce'),
    ('Rap'),
    ('Cloud Rap'),
    ('Comedy Rap'),
    ('Conscious Hip Hop'),
    ('Country Rap'),
    ('Disco Rap'),
    ('Emo Rap'),
    ('Experimental Hip Hop'),
    ('Hardcore Hip Hop'),
    ('Instrumental Hip Hop'),
    ('Jazz Rap'),
    ('Lo-Fi Hip Hop'),
    ('Political Hip Hop'),
    ('Pop Rap'),
    ('Post-Industrial'),
    ('Afro-Jazz'),
    ('Avant-Garde Jazz'),
    ('Chamber Jazz'),
    ('Cool Jazz'),
    ('Dark Jazz'),
    ('Jazz-Funk'),
    ('Jazz Fusion'),
    ('Jazz manouche'),
    ('Smooth Jazz'),
    ('Soul Jazz'),
    ('Swing'),
    ('Vocal Jazz'),
    ('Metal'),
    ('Alternative Metal'),
    ('Black Metal'),
    ('Death Metal'),
    ('Doom Metal'),
    ('Drone Metal'),
    ('Folk Metal'),
    ('Gothic Metal'),
    ('Grindcore'),
    ('Groove Metal'),
    ('Heavy Metal'),
    ('Industrial Metal'),
    ('Metalcore'),
    ('Post-Metal'),
    ('Power Metal'),
    ('Progressive Metal'),
    ('Sludge Metal'),
    ('Stoner Metal'),
    ('Symphonic Metal'),
    ('Thrash Metal'),
    ('Viking Metal'),
    ('New Age'),
    ('Pop'),
    ('Ambient Pop'),
    ('Art Pop'),
    ('Baroque Pop'),
    ('Folk Pop'),
    ('Indie Pop'),
    ('Jazz Pop'),
    ('J-Pop'),
    ('K-Pop'),
    ('Pop Rock'),
    ('Pop Soul'),
    ('Progressive Pop'),
    ('Psychedelic Pop'),
    ('Psychedelia'),
    ('Neo-Psychedelia'),
    ('Psychedelic Folk'),
    ('Psychedelic Rock'),
    ('Psychedelic Soul'),
    ('Punk'),
    ('Art Punk'),
    ('Emo'),
    ('Post-Punk'),
    ('Punk Rock'),
    ('R&B'),
    ('Funk'),
    ('Soul'),
    ('Regional Music'),
    ('Rock'),
    ('Acoustic Rock'),
    ('Alternative Rock'),
    ('Art Rock'),
    ('Blues Rock'),
    ('Comedy Rock'),
    ('Country Rock'),
    ('Experimental Rock'),
    ('Folk Rock'),
    ('Funk Rock'),
    ('Garage Rock'),
    ('Glam Rock'),
    ('Hard Rock'),
    ('Heartland Rock'),
    ('Industrial Rock'),
    ('Jazz-Rock'),
    ('Math Rock'),
    ('New Wave'),
    ('Noise Rock'),
    ('Post-Rock'),
    ('Progressive Rock'),
    ('Proto-Punk'),
    ('Rap Rock'),
    ('Southern Rock'),
    ('Singer/Songwriter'),
    ('Ska'),
    ('2 Tone'),
    ('Soundtracks'),
    ('Film Soundtrack'),
    ('Video Game Music')
GO

-- Add main labels.
INSERT INTO [dbo].[Label]([Name], [Location], [FoundationYear]) VALUES
    ('RCA Victor', 'États-Unis', 1929),
    ('RCA Records', 'États-Unis', 1945),
    ('EMI Records', 'Royaume-Uni', 1931),
    ('Virgin Records', 'Royaume-Uni', 1973),
    ('Parlophone', 'Allemagne', 1896),
    ('Columbia Records', 'États-Unis', 1888);
GO

-- Test albums.
EXEC [dbo].[SSP_CreateArtist] 'David Bowie', NULL, 'David Robert Jones', '1947-01-08', '2016-01-10', 'He was a space invader.';
EXEC [dbo].[SSP_CreateArtist] 'Nirvana', NULL, NULL, '1987', NULL, NULL;

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

-- Test users.
EXEC [dbo].[SSP_CreateUser] 'Kardygan', 'Tommy', 'Laczny', 'k.sn4ily@gmail.com', '@test1234!', '../Uploads/All/default_avatar.jpg', 'Belgique', 'I''m the boss here!';
EXEC [dbo].[SSP_CreateUser] 'MadMax', NULL, NULL, 'john.doe@gmail.com', '@test1234!', NULL, NULL, NULL;
GO