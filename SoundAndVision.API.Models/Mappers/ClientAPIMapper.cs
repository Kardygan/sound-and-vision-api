using SoundAndVision.API.Models.Entities;
using CE = SoundAndVision.API.Models.Client.Entities;

namespace SoundAndVision.API.Models.Mappers
{
    public static class ClientAPIMapper
    {
        // User mapper.
        public static User ToUserAPI(this CE.User user)
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

        // Artist mapper.
        public static Artist ToArtistAPI(this CE.Artist artist)
        {
            return new Artist()
            {
                Id = artist.Id,
                Name = artist.Name,
                Picture = artist.Picture,
                Alias = artist.Alias,
                StartDate = artist.StartDate,
                EndDate = artist.EndDate,
                Description = artist.Description
            };
        }
    }
}
