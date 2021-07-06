using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Global.Entities
{
    public class TrackFull
    {
        public int Id { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public short? Duration { get; set; }
    }
}
