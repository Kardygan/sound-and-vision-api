using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Global.Entities
{
    public class Track
    {
        public string Num { get; set; }
        public string Name { get; set; }
        public short? Duration { get; set; }
        public int AlbumId { get; set; }
    }
}
