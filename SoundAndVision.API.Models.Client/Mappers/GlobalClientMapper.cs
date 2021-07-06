using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoundAndVision.API.Models.Client.Mappers
{
    internal static class GlobalClientMapper
    {
        // User.
        internal static GE.User ToUserGlobal(this User user)
        {
            return new GE.User()
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Picture = user.Picture,
                Location = user.Location,
                Bio = user.Bio
            };
        }

        internal static User ToUserClient(this GE.User user)
        {
            try
            {
                return new User(user.Id, user.Username, user.FirstName, user.LastName, user.Email, user.Picture, user.Location, user.Bio, user.RegistrationDate, user.IsActive, user.RoleId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Artist.
        internal static GE.Artist ToArtistGlobal(this Artist artist)
        {
            return new GE.Artist()
            {
                Name = artist.Name,
                Picture = artist.Picture,
                Alias = artist.Alias,
                StartDate = artist.StartDate,
                EndDate = artist.EndDate,
                Description = artist.Description
            };
        }

        internal static Artist ToArtistClient(this GE.Artist artist)
        {
            return new Artist(artist.Id, artist.Name, artist.Picture, artist.Alias, artist.StartDate, artist.EndDate, artist.Description);
        }

        // Album.
        internal static GE.Album ToAlbumGlobal(this Album album)
        {
            return new GE.Album()
            {
                Name = album.Name,
                Cover = album.Cover,
                ReleaseDate = album.ReleaseDate,
                Description = album.Description,
                LabelId = album.LabelId,
                AlbumTypeId = album.AlbumTypeId,
                ArtistIds = album.ArtistIds,
                GenreIds = album.GenreIds,
                Tracks = album.Tracks.Select(track => track.ToTrackGlobal())
            };
        }

        internal static AlbumFull ToAlbumFullClient(this GE.AlbumFull album)
        {
            return new AlbumFull(album.Id, album.Name, album.Cover, album.ReleaseDate, album.Description, album.Label.ToLabelClient(), album.AlbumType.ToAlbumTypeClient(), album.Artists.Select(artist => artist.ToArtistClient()), album.Genres.Select(genre => genre.ToGenreClient()), album.Tracks.Select(track => track.ToTrackClient()));
        }

        // Label.
        internal static GE.Label ToLabelGlobal(this Label label)
        {
            return new GE.Label()
            {
                Name = label.Name,
                Picture = label.Picture,
                Location = label.Location,
                FoundationYear = label.FoundationYear
            };
        }

        internal static Label ToLabelClient(this GE.Label label)
        {
            return new Label(label.Id, label.Name, label.Picture, label.Location, label.FoundationYear);
        }

        // AlbumType.
        internal static GE.AlbumType ToAlbumTypeGlobal(this AlbumType albumType)
        {
            return new GE.AlbumType()
            {
                Name = albumType.Name
            };
        }

        internal static AlbumType ToAlbumTypeClient(this GE.AlbumType albumType)
        {
            return new AlbumType(albumType.Id, albumType.Name);
        }

        // Genre.
        internal static GE.Genre ToGenreGlobal(this Genre genre)
        {
            return new GE.Genre()
            {
                Name = genre.Name
            };
        }

        internal static Genre ToGenreClient(this GE.Genre genre)
        {
            return new Genre(genre.Id, genre.Name);
        }

        // Track.
        internal static GE.Track ToTrackGlobal(this Track track)
        {
            return new GE.Track()
            {
                Num = track.Num,
                Name = track.Name,
                Duration = track.Duration//,
                //AlbumId = track.AlbumId
            };
        }

        internal static Track ToTrackClient(this GE.Track track)
        {
            return new Track(track.Id, track.Num, track.Name, track.Duration
                //, track.AlbumId
                );
        }
    }
}
