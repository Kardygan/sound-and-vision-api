using SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Models.Global.Mappers;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Tools.Connection.Database;

namespace SoundAndVision.API.Models.Global.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        private Connection _connection;

        public UserRepository(Connection connection)
        {
            _connection = connection;
        }

        public bool Edit(int id, User user)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            try
            {
                Command command = new Command("SSP_GetUserById", true);
                command.AddParameter("@Id", id);

                return _connection.ExecuteReader(command, userData => userData.ToUserGlobal()).SingleOrDefault();
            }
            catch (SqlException sex)
            {
                throw new Exception(sex.Message);
            }
            catch (Exception)
            {
                throw new Exception("User doesn't exist!");
            }
        }

        public IEnumerable<User> Get()
        {
            try
            {
                Command command = new Command("SSP_GetAllUser", true);

                return _connection.ExecuteReader(command, userData => userData.ToUserGlobal());
            }
            catch (SqlException sex)
            {
                throw new Exception(sex.Message);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong!");
            }
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
