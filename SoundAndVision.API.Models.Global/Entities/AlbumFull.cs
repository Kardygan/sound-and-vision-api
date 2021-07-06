using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Global.Entities
{
    public class AlbumFull
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Description { get; set; }
        public Label Label { get; set; }
        public AlbumType AlbumType { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<TrackFull> Tracks { get; set; }
    }
}
