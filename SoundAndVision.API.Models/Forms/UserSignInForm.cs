using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoundAndVision.API.Models.Forms
{
    public class UserSignInForm
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(384)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
