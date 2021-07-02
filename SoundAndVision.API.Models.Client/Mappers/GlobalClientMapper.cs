using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Models.Client.Mappers
{
    internal static class GlobalClientMapper
    {
        // User mapper.
        internal static GE.User ToUserGlobal(this User user)
        {
            return new GE.User()
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Picture = user.Picture,
                Location = user.Location,
                Bio = user.Bio
            };
        }

        internal static User ToUserClient(this GE.User user)
        {
            return new User(user.Id, user.Username, user.FirstName, user.LastName, user.Email, user.Picture, user.Location, user.Bio, user.RegistrationDate, user.IsActive, user.RoleId);
        }

        // Artist mapper.
        internal static GE.Artist ToArtistGlobal(this Artist artist)
        {
            return new GE.Artist()
            {
                Name = artist.Name,
                Picture = artist.Picture,
                Alias = artist.Alias,
                StartDate = artist.StartDate,
                EndDate = artist.EndDate,
                Description = artist.Description
            };
        }

        internal static Artist ToArtistClient(this GE.Artist artist)
        {
            return new Artist(artist.Id, artist.Name, artist.Picture, artist.Alias, artist.StartDate, artist.EndDate, artist.Description);
        }
    }
}
