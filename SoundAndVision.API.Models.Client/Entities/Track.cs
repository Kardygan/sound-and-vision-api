using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class Track
    {
        public Track(string num, string name, short? duration/*, int albumId*/)
        {
            Num = num;
            Name = name;
            Duration = duration;
            //AlbumId = albumId;
        }

        internal Track(int id, string num, string name, short? duration/*, int albumId*/)
            : this(num, name, duration/*, albumId*/)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public short? Duration { get; set; }
        //public int AlbumId { get; set; }
    }
}
