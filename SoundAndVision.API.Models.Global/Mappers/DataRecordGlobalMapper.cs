using SoundAndVision.API.Models.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SoundAndVision.API.Models.Global.Mappers
{
    internal static class DataRecordGlobalMapper
    {
        // User.
        internal static User ToUserGlobal(this IDataRecord dataRecord)
        {
            return new User()
            {
                Id = (int)dataRecord["Id"],
                Username = (string)dataRecord["Username"],
                FirstName = (dataRecord["FirstName"] is DBNull) ? null : (string)dataRecord["FirstName"],
                LastName = (dataRecord["LastName"] is DBNull) ? null : (string)dataRecord["LastName"],
                Email = (string)dataRecord["Email"],
                Password = null,
                Picture = (string)dataRecord["Picture"],
                Location = (dataRecord["Location"] is DBNull) ? null : (string)dataRecord["Location"],
                Bio = (dataRecord["Bio"] is DBNull) ? null : (string)dataRecord["Bio"],
                RegistrationDate = (DateTime)dataRecord["RegistrationDate"],
                IsActive = (bool)dataRecord["IsActive"],
                RoleId = (int)dataRecord["RoleId"]
            };
        }

        // Artist.
        internal static Artist ToArtistGlobal(this IDataRecord dataRecord)
        {
            return new Artist()
            {
                Id = (int)dataRecord["Id"],
                Name = (string)dataRecord["Name"],
                Picture = (string)dataRecord["Picture"],
                Alias = (dataRecord["Alias"] is DBNull) ? null : (string)dataRecord["Alias"],
                StartDate = (DateTime)dataRecord["StartDate"],
                EndDate = (dataRecord["EndDate"] is DBNull) ? (DateTime?)null : (DateTime)dataRecord["EndDate"],
                Description = (dataRecord["Description"] is DBNull) ? null : (string)dataRecord["Description"]
            };
        }

        internal static Artist ToAlbumArtistGlobal(this IDataRecord dataRecord)
        {
            return new Artist()
            {
                Id = (int)dataRecord["ArtistId"],
                Name = (string)dataRecord["ArtistName"],
                Picture = (string)dataRecord["ArtistPicture"],
                Alias = (dataRecord["ArtistAlias"] is DBNull) ? null : (string)dataRecord["ArtistAlias"],
                StartDate = (DateTime)dataRecord["ArtistStartDate"],
                EndDate = (dataRecord["ArtistEndDate"] is DBNull) ? (DateTime?)null : (DateTime)dataRecord["ArtistEndDate"],
                Description = (dataRecord["ArtistDescription"] is DBNull) ? null : (string)dataRecord["ArtistDescription"]
            };
        }

        internal static ArtistFull ToAlbumArtistFullGlobal(this IDataRecord dataRecord)
        {
            return new ArtistFull()
            {
                Id = (int)dataRecord["ArtistId"],
                Name = (string)dataRecord["ArtistName"],
                Picture = (string)dataRecord["ArtistPicture"],
                Alias = (dataRecord["ArtistAlias"] is DBNull) ? null : (string)dataRecord["ArtistAlias"],
                StartDate = (DateTime)dataRecord["ArtistStartDate"],
                EndDate = (dataRecord["ArtistEndDate"] is DBNull) ? (DateTime?)null : (DateTime)dataRecord["ArtistEndDate"],
                Description = (dataRecord["ArtistDescription"] is DBNull) ? null : (string)dataRecord["ArtistDescription"],
                AlbumId = (int)dataRecord["Id"]
            };
        }

        // Album.
        internal static AlbumFull ToAlbumFullGlobal(this IDataRecord dataRecord)
        {
            return new AlbumFull()
            {
                Id = (int)dataRecord["Id"],
                Name = (string)dataRecord["Name"],
                Cover = (string)dataRecord["Cover"],
                ReleaseDate = (dataRecord["ReleaseDate"] is DBNull) ? (DateTime?)null : (DateTime)dataRecord["ReleaseDate"],
                Description = (dataRecord["Description"] is DBNull) ? null : (string)dataRecord["Description"],
                Label = new Label()
                {
                    Id = (int)dataRecord["LabelId"],
                    Name = (string)dataRecord["LabelName"],
                    Picture = (string)dataRecord["LabelPicture"],
                    Location = (string)dataRecord["LabelLocation"],
                    FoundationYear = (short)dataRecord["LabelFoundationYear"]
                },
                AlbumType = new AlbumType()
                {
                    Id = (int)dataRecord["AlbumTypeId"],
                    Name = (string)dataRecord["AlbumTypeName"]
                }
            };
        }

        // Label.
        internal static Label ToLabelGlobal(this IDataRecord dataRecord)
        {
            return new Label()
            {
                Id = (int)dataRecord["Id"],
                Name = (string)dataRecord["Name"],
                Picture = (string)dataRecord["Picture"],
                Location = (string)dataRecord["Location"],
                FoundationYear = (short)dataRecord["FoudationYear"]
            };
        }

        // AlbumType.
        internal static AlbumType ToAlbumTypeGlobal(this IDataRecord dataRecord)
        {
            return new AlbumType()
            {
                Id = (int)dataRecord["Id"],
                Name = (string)dataRecord["Name"]
            };
        }

        // Genre.
        internal static Genre ToGenreGlobal(this IDataRecord dataRecord)
        {
            return new Genre()
            {
                Id = (int)dataRecord["Id"],
                Name = (string)dataRecord["Name"]
            };
        }

        internal static Genre ToAlbumGenreGlobal(this IDataRecord dataRecord)
        {
            return new Genre()
            {
                Id = (int)dataRecord["GenreId"],
                Name = (string)dataRecord["GenreName"]
            };
        }

        internal static GenreFull ToAlbumGenreFullGlobal(this IDataRecord dataRecord)
        {
            return new GenreFull()
            {
                Id = (int)dataRecord["GenreId"],
                Name = (string)dataRecord["GenreName"],
                AlbumId = (int)dataRecord["Id"],
            };
        }

        // Track.
        internal static Track ToAlbumTrackGlobal(this IDataRecord dataRecord)
        {
            return new Track()
            {
                Id = (int)dataRecord["TrackId"],
                Num = (string)dataRecord["TrackNum"],
                Name = (string)dataRecord["TrackName"],
                Duration = (dataRecord["TrackDuration"] is DBNull) ? (short?)null : (short)dataRecord["TrackDuration"]
            };
        }

        internal static TrackFull ToAlbumTrackFullGlobal(this IDataRecord dataRecord)
        {
            return new TrackFull()
            {
                Id = (int)dataRecord["TrackId"],
                Num = (string)dataRecord["TrackNum"],
                Name = (string)dataRecord["TrackName"],
                Duration = (dataRecord["TrackDuration"] is DBNull) ? (short?)null : (short)dataRecord["TrackDuration"],
                AlbumId = (int)dataRecord["Id"]
            };
        }
    }
}
