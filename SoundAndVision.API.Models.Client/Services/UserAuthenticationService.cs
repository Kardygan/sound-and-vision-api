using SoundAndVision.API.Models.Client.Entities;
using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SoundAndVision.API.Models.Client.Mappers;

namespace SoundAndVision.API.Models.Client.Services
{
    public class UserAuthenticationService : IUserAuthenticationRepository<User>
    {
        private IUserAuthenticationRepository<GE.User> _userAuthenticationRepository;

        public UserAuthenticationService(IUserAuthenticationRepository<GE.User> userAuthenticationRepository)
        {
            _userAuthenticationRepository = userAuthenticationRepository;
        }

        public int Register(User user)
        {
            try
            {
                int id = _userAuthenticationRepository.Register(user.ToUserGlobal());
                user.Password = null;

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User SignIn(string email, string password)
        {
            try
            {
                return _userAuthenticationRepository.SignIn(email, password).ToUserClient();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
