using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class Genre
    {
        public Genre(string name)
        {
            Name = name;
        }

        internal Genre(int id, string name)
            : this(name)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
    }
}
