using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoundAndVision.API.Models.Forms
{
    public class UserRegisterForm
    {
        [Required]
        [RegularExpression(@"^(?=.{3,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Invalid username")]
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
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,30}$", ErrorMessage = "The password must be between 8 and 30 characters and have at least one uppercase letter, one lowercase letter, one number and one special character.")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "The image extension must be in .png, .jpg or.gif")]
        public string Picture { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(4000)]
        public string Bio { get; set; }
    }
}
