using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class AlbumType
    {
        public AlbumType(string name)
        {
            Name = name;
        }

        internal AlbumType(int id, string name)
            : this(name)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
