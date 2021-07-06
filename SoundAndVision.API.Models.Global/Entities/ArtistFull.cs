using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Global.Entities
{
    public class ArtistFull
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Alias { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public int AlbumId { get; set; }
    }
}
