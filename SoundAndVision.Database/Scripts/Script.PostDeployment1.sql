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

-- ***********************************************************************************
--
-- Insert important data during database publication process.
--
-- ***********************************************************************************

-- Add roles.
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
    ('Alternative'),
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
EXEC [dbo].[SSP_CreateLabel] 'RCA Victor', NULL, 'États-Unis', 1929;
EXEC [dbo].[SSP_CreateLabel] 'RCA Records', NULL, 'États-Unis', 1945;
EXEC [dbo].[SSP_CreateLabel] 'EMI Records', NULL, 'Royaume-Uni', 1931;
EXEC [dbo].[SSP_CreateLabel] 'Virgin Records', NULL, 'Royaume-Uni', 1973;
EXEC [dbo].[SSP_CreateLabel] 'Parlophone', NULL, 'Allemagne', 1896;
EXEC [dbo].[SSP_CreateLabel] 'Columbia Records', NULL, 'États-Unis', 1888;
GO

-- ***********************************************************************************
--
-- Test section.
--
-- ***********************************************************************************

-- Test albums.
EXEC [dbo].[SSP_CreateArtist] 'David Bowie', 'Uploads/Artists/davidbowie.jpg', 'David Robert Jones', '1947-01-08', '2016-01-10', 'He was a space invader.';
EXEC [dbo].[SSP_CreateArtist] 'Nirvana', 'Uploads/Artists/nirvana.jpg', NULL, '1987', '1994-04-08', 'Un groupe inconnu des années 90.';
GO

EXEC [dbo].[SSP_CreateAlbum] 'The Rise and Fall of Ziggy Stardust and the Spiders From Mars', 'Uploads/Albums/ziggy.jpg', '1972-06-12', NULL, 1, 1;
EXEC [dbo].[SSP_CreateAlbum] 'Low', 'Uploads/Albums/low.jpg', '1977-01-14', NULL, 1, 1;
EXEC [dbo].[SSP_CreateAlbum] 'Nevermind', 'Uploads/Albums/nevermind.jpg', '1991-09-24', NULL, 6, 1;
EXEC [dbo].[SSP_CreateAlbum] 'MTV Unplugged in New York', 'Uploads/Albums/mtv.jpg', '1994-11-01', 'MTV Unplugged in New York est un album live du groupe américain de grunge Nirvana, publié le 1er novembre 1994 en CD par DGC Records, puis le 20 novembre 2007 en DVD. Alors en tournée pour promouvoir In Utero, mais dont les ventes sont plus faibles que celles espérées, le groupe accepte de participer à l''émission MTV Unplugged. Dans une ambiance tendue entre Kurt Cobain et les représentants de la chaîne, ils répètent deux jours avant d''enregistrer en une seule prise l''intégralité du concert le 18 novembre 1993 dans les studios Sony Music de New York. Diffusée le 12 décembre, leur prestation permet à leur album studio de franchir la barre du million de copies vendues, mais également de donner un nouveau souffle au programme télévisuel.', 6, 2;
EXEC [dbo].[SSP_CreateAlbum] 'La collaboration qui n''est jamais arrivée', NULL, '1993', NULL, 3, 4;
GO

EXEC [dbo].[SSP_CreateAlbumArtist] 1, 1; -- Ziggy Stardust              - David Bowie
EXEC [dbo].[SSP_CreateAlbumArtist] 2, 1; -- Low                         - David Bowie
EXEC [dbo].[SSP_CreateAlbumArtist] 3, 2; -- Nevermind                   - Nirvana
EXEC [dbo].[SSP_CreateAlbumArtist] 4, 2; -- MTV Unplugged in New York   - Nirvana
EXEC [dbo].[SSP_CreateAlbumArtist] 5, 1; -- La collaboration de la mort - David Bowie
EXEC [dbo].[SSP_CreateAlbumArtist] 5, 2; -- La collaboration de la mort - Nirvana
GO

EXEC [dbo].[SSP_CreateAlbumGenre] 1, 131; -- Ziggy Stardust             - Glam Rock
EXEC [dbo].[SSP_CreateAlbumGenre] 1, 123; -- Ziggy Stardust             - Art Rock
EXEC [dbo].[SSP_CreateAlbumGenre] 2, 123; -- Low                        - Art Rock
EXEC [dbo].[SSP_CreateAlbumGenre] 2, 31; -- Low                         - Experimental
EXEC [dbo].[SSP_CreateAlbumGenre] 3, 122; -- Nevermind                  - Alternative
EXEC [dbo].[SSP_CreateAlbumGenre] 4, 122; -- MTV Unplugged in New York  - Alternative
EXEC [dbo].[SSP_CreateAlbumGenre] 5, 119; -- La collaboration de la mort - Rock
GO

EXEC [dbo].[SSP_CreateTrack] 1, 'Five Years', 282, 1;
EXEC [dbo].[SSP_CreateTrack] 2, 'Soul Love', 213, 1;
EXEC [dbo].[SSP_CreateTrack] 3, 'Moonage Daydream', 277, 1;
EXEC [dbo].[SSP_CreateTrack] 4, 'Starman', 256, 1;
EXEC [dbo].[SSP_CreateTrack] 5, 'It Ain''t Easy', 179, 1;
EXEC [dbo].[SSP_CreateTrack] 6, 'Lady Stardust', 201, 1;
EXEC [dbo].[SSP_CreateTrack] 7, 'Star', 166, 1;
EXEC [dbo].[SSP_CreateTrack] 8, 'Hang On to Yourself', 158, 1;
EXEC [dbo].[SSP_CreateTrack] 9, 'Ziggy Stardust', 193, 1;
EXEC [dbo].[SSP_CreateTrack] 10, 'Suffragette City', 205, 1;
EXEC [dbo].[SSP_CreateTrack] 11, 'Rock ''n'' Roll Suicide', 181, 1;

EXEC [dbo].[SSP_CreateTrack] 1, 'Speed of Life', 167, 2;
EXEC [dbo].[SSP_CreateTrack] 2, 'Breaking Glass', 112, 2;
EXEC [dbo].[SSP_CreateTrack] 3, 'What in the World', 143, 2;
EXEC [dbo].[SSP_CreateTrack] 4, 'Sound and Vision', 183, 2;
EXEC [dbo].[SSP_CreateTrack] 5, 'Always Crashing in the Same Car', 213, 2;
EXEC [dbo].[SSP_CreateTrack] 6, 'Be My Wife', 176, 2;
EXEC [dbo].[SSP_CreateTrack] 7, 'A New Career in a New Town', 175, 2;
EXEC [dbo].[SSP_CreateTrack] 8, 'Warszawa', 383, 2;
EXEC [dbo].[SSP_CreateTrack] 9, 'Art Decade', 227, 2;
EXEC [dbo].[SSP_CreateTrack] 10, 'Weeping Wall', 208, 2;
EXEC [dbo].[SSP_CreateTrack] 11, 'Subterraneans', 341, 2;

EXEC [dbo].[SSP_CreateTrack] 1, 'Smells Like Teen Spirit', 301, 3;
EXEC [dbo].[SSP_CreateTrack] 2, 'In Bloom', 254, 3;
EXEC [dbo].[SSP_CreateTrack] 3, 'Come as You Are', 218, 3;
EXEC [dbo].[SSP_CreateTrack] 4, 'Breed', 183, 3;
EXEC [dbo].[SSP_CreateTrack] 5, 'Lithium', 256, 3;
EXEC [dbo].[SSP_CreateTrack] 6, 'Polly', 176, 3;
EXEC [dbo].[SSP_CreateTrack] 7, 'Territorial Pissings', 142, 3;
EXEC [dbo].[SSP_CreateTrack] 8, 'Drain You', 223, 3;
EXEC [dbo].[SSP_CreateTrack] 9, 'Lounge Act', 156, 3;
EXEC [dbo].[SSP_CreateTrack] 10, 'Stay Away', 212, 3;
EXEC [dbo].[SSP_CreateTrack] 11, 'On a Plain', 196, 3;
EXEC [dbo].[SSP_CreateTrack] 12, 'Something in the Way', 231, 3;

EXEC [dbo].[SSP_CreateTrack] 1, 'About a Girl', 217, 4;
EXEC [dbo].[SSP_CreateTrack] 2, 'Come as You Are', 253, 4;
EXEC [dbo].[SSP_CreateTrack] 3, 'Jesus Doesn''t Want Me for a Sunbeam', 277, 4;
EXEC [dbo].[SSP_CreateTrack] 4, 'The Man Who Sold the World', 260, 4;
EXEC [dbo].[SSP_CreateTrack] 5, 'Pennyroyal Tea', 220, 4;
EXEC [dbo].[SSP_CreateTrack] 6, 'Dumb', 172, 4;
EXEC [dbo].[SSP_CreateTrack] 7, 'Polly', 196, 4;
EXEC [dbo].[SSP_CreateTrack] 8, 'On a Plain', 224, 4;
EXEC [dbo].[SSP_CreateTrack] 9, 'Something in the Way', 241, 4;
EXEC [dbo].[SSP_CreateTrack] 10, 'Plateau', 217, 4;
EXEC [dbo].[SSP_CreateTrack] 11, 'Oh Me', 205, 4;
EXEC [dbo].[SSP_CreateTrack] 12, 'Lake of Fire', 175, 4;
EXEC [dbo].[SSP_CreateTrack] 13, 'All Apologies', 262, 4;
EXEC [dbo].[SSP_CreateTrack] 14, 'Where Did You Sleep Last Night', 305, 4;

EXEC [dbo].[SSP_CreateTrack] 1, 'The Man Who Sold the World', 260, 5;
GO

-- Test users.
EXEC [dbo].[SSP_CreateUser] 'Kardygan', 'Tommy', 'Laczny', 'admin@gmail.com', '@test1234!', 'Uploads/Avatars/ohlongjohnson.png', 'Belgique', 'I''m the boss here!';
EXEC [dbo].[SSP_CreateUser] 'DoomSlayer', 'Inconnu', 'Inconnu', 'doom@gmail.com', '@test1234!', 'Uploads/Avatars/doomguy.jpg', 'Enfer', NULL;
EXEC [dbo].[SSP_CreateUser] 'MadMax', NULL, NULL, 'max.max@gmail.com', '@test1234!', 'Uploads/Avatars/madmax.jpg', 'Australie', NULL;
EXEC [dbo].[SSP_CreateUser] 'Snake', 'S.D', 'Plissken', 's.plissken@gmail.com', '@test1234!', 'Uploads/Avatars/snake.jpg', 'États-Unis', NULL;
GO

-- Test set roles.
EXEC [dbo].[SSP_SetAdminRole] 1; -- Kardygan        - Admin
EXEC [dbo].[SSP_SetModeratorRole] 2; -- DoomSlayer  - Moderator
EXEC [dbo].[SSP_SetContributorRole] 3; -- MadMax    - Contributor
EXEC [dbo].[SSP_SetUserRole] 4; -- Snake            - User
GO