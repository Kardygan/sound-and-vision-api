using SoundAndVision.API.Models.Client.Entities;
using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SoundAndVision.API.Models.Client.Mappers;
using System.Linq;

namespace SoundAndVision.API.Models.Client.Services
{
    public class UserService : IUserRepository<User>
    {
        private IUserRepository<GE.User> _userRepository;

        public UserService(IUserRepository<GE.User> userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Edit(int id, User user)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            try
            {
                return _userRepository.Get(id).ToUserClient();
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
                return _userRepository.Get().Select(user => user.ToUserClient());
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
