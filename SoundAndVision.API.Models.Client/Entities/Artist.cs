using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class Artist
    {
        public Artist(string name, string picture, string alias, DateTime startDate, DateTime? endDate, string description)
        {
            Name = name;
            Picture = picture;
            Alias = alias;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }

        internal Artist(int id, string name, string picture, string alias, DateTime startDate, DateTime? endDate, string description)
            : this(name, picture, alias, startDate, endDate, description)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Alias { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}
