using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Entities
{
    public class User
    {
        public User(string username, string firstName, string lastName, string email, string password, string picture, string location, string bio)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Picture = picture;
            Location = location;
            Bio = bio;
        }

        internal User(int id, string username, string firstName, string lastName, string email, string picture, string location, string bio, DateTime registrationDate, bool isActive, int roleId)
            : this(username, firstName, lastName, email, null, picture, location, bio)
        {
            Id = id;
            RegistrationDate = registrationDate;
            IsActive = isActive;
            RoleId = roleId;
        }

        public int Id { get; private set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public DateTime RegistrationDate { get; private set; }
        public bool IsActive { get; private set; }
        public int RoleId { get; private set; }
    }
}
