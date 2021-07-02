using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Repositories.Interfaces
{
    public interface IUserRepository<TUser>
    {
        IEnumerable<TUser> Get();
        TUser Get(int id);
        bool Edit(int id, TUser user);
        bool Remove(int id);
    }
}
