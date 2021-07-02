﻿using SoundAndVision.API.Models.Client.Entities;
using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SoundAndVision.API.Models.Client.Mappers;

namespace SoundAndVision.API.Models.Client.Repositories
{
    public class UserAuthenticationRepository : IUserAuthenticationRepository<User>
    {
        private IUserAuthenticationRepository<GE.User> _userAuthenticationRepositoryGlobal;

        public UserAuthenticationRepository(IUserAuthenticationRepository<GE.User> userAuthenticationRepositoryGlobal)
        {
            _userAuthenticationRepositoryGlobal = userAuthenticationRepositoryGlobal;
        }

        public int Register(User user)
        {
            try
            {
                int id = _userAuthenticationRepositoryGlobal.Register(user.ToUserGlobal());
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
                return _userAuthenticationRepositoryGlobal.SignIn(email, password).ToUserClient();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
