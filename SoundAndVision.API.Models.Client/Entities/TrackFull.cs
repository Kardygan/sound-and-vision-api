using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class TrackFull
    {
        public TrackFull(int id, string num, string name, short? duration)
        {
            Id = id;
            Num = num;
            Name = name;
            Duration = duration;
        }

        public int Id { get; private set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public short? Duration { get; set; }
    }
}
