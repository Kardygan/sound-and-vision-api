using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoundAndVision.API.Models.Entities.Forms
{
    public class ArtistAddForm
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$")]
        public string Picture { get; set; }
        [StringLength(300)]
        public string Alias { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
    }
}
