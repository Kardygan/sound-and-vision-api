using SoundAndVision.API.Models.Client.Entities;
using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SoundAndVision.API.Models.Client.Mappers;
using System.Linq;

namespace SoundAndVision.API.Models.Client.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        private IUserRepository<GE.User> _userRepositoryGlobal;

        public UserRepository(IUserRepository<GE.User> userRepositoryGlobal)
        {
            _userRepositoryGlobal = userRepositoryGlobal;
        }

        public bool Edit(int id, User user)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            try
            {
                return _userRepositoryGlobal.Get(id).ToUserClient();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<User> Get()
        {
            try
            {
                return _userRepositoryGlobal.Get().Select(user => user.ToUserClient());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
