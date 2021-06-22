using CE = SoundAndVision.API.Models.Client.Entities;
using SoundAndVision.API.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Models.Mappers
{
    internal static class ClientAPIMapper
    {
        internal static User ToUserAPI(this CE.User user)
        {
            return new User()
            {
                Id = user.Id,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Picture = user.Picture,
                Location = user.Location,
                Bio = user.Bio,
                RegistrationDate = user.RegistrationDate,
                IsActive = user.IsActive,
                RoleId = user.RoleId
            };
        }
    }
}
