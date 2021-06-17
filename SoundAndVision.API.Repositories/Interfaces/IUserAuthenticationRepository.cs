using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Repositories.Interfaces
{
    public interface IUserAuthenticationRepository<TUser>
    {
        bool Register(TUser user);
        TUser SignIn(string email, string password);
    }
}
