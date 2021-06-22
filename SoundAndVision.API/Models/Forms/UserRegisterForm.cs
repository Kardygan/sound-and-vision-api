using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Models.Forms
{
    public class UserRegisterForm
    {
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(384)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$")]
        public string Picture { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(4000)]
        public string Bio { get; set; }
    }
}
