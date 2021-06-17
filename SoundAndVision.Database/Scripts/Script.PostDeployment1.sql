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
    (3, 'User');
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

-- Test user.
EXEC [dbo].[SSP_CreateUser] 'Kardygan', 'Tommy', 'Laczny', 'k.sn4ily@gmail.com', '@test1234!', '../Uploads/All/default_avatar.jpg', 'Belgique', 'I''m the boss here!';
GO