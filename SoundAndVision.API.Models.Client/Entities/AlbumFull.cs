using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class AlbumFull
    {
        public AlbumFull(int id, string name, string cover, DateTime? releaseDate, string description, Label label, AlbumType albumType, IEnumerable<Artist> artists, IEnumerable<Genre> genres, IEnumerable<Track> tracks)
        {
            Id = id;
            Name = name;
            Cover = cover;
            ReleaseDate = releaseDate;
            Description = description;
            Label = label;
            AlbumType = albumType;
            Artists = artists;
            Genres = genres;
            Tracks = tracks;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Description { get; set; }
        public Label Label { get; private set; }
        public AlbumType AlbumType { get; private set; }
        public IEnumerable<Artist> Artists { get; private set; }
        public IEnumerable<Genre> Genres { get; private set; }
        public IEnumerable<Track> Tracks { get; set; }
    }
}
