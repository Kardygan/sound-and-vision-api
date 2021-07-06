using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class Album
    {
        public Album(string name, string cover, DateTime? releaseDate, string description, int labelId, int albumTypeId, int[] artistIds, int[] genreIds, IEnumerable<Track> tracks)
        {
            Name = name;
            Cover = cover;
            ReleaseDate = releaseDate;
            Description = description;
            LabelId = labelId;
            AlbumTypeId = albumTypeId;
            ArtistIds = artistIds;
            GenreIds = genreIds;
            Tracks = tracks;
        }

        public string Name { get; set; }
        public string Cover { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Description { get; set; }
        public int LabelId { get; set; }
        public int AlbumTypeId { get; set; }
        public int[] ArtistIds { get; set; }
        public int[] GenreIds { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
    }
}
