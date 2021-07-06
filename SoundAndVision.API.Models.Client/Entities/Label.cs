using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class Label
    {
        public Label(string name, string picture, string location, short foundationYear)
        {
            Name = name;
            Picture = picture;
            Location = location;
            FoundationYear = foundationYear;
        }

        internal Label(int id, string name, string picture, string location, short foundationYear)
            : this(name, picture, location, foundationYear)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Location { get; set; }
        public short FoundationYear { get; set; }
    }
}
