using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Global.Entities
{
    public class Album
    {
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
