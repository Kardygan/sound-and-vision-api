using SoundAndVision.API.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Infrastructure.Interfaces
{
    public interface ITokenManager
    {
        User Authenticate(User user);
    }
}
