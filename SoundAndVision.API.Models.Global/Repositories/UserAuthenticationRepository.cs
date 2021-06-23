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
    public class UserAuthenticationRepository : IUserAuthenticationRepository<User>
    {
        private Connection _connection;

        public UserAuthenticationRepository(Connection connection)
        {
            _connection = connection;
        }

        public int Register(User user)
        {
            try
            {
                Command command = new Command("SSP_CreateUser", true);
                command.AddParameter("@Username", user.Username);
                command.AddParameter("@FirstName", user.FirstName);
                command.AddParameter("@LastName", user.LastName);
                command.AddParameter("@Email", user.Email);
                command.AddParameter("@Password", user.Password);
                command.AddParameter("@Picture", user.Picture);
                command.AddParameter("@Location", user.Location);
                command.AddParameter("@Bio", user.Bio);

                int id = (int)_connection.ExecuteScalar(command);
                user.Password = null;

                return id;
            }
            catch (SqlException sex)
            {
                throw new Exception(sex.Message);
            }
            catch (Exception)
            {
                throw new Exception("User could not be added!");
            }
        }

        public User SignIn(string email, string password)
        {
            try
            {
                Command command = new Command("SSP_LoginUser", true);
                command.AddParameter("@Email", email);
                command.AddParameter("@Password", password);

                return _connection.ExecuteReader(command, (dataRecord) => dataRecord.ToUserGlobal()).SingleOrDefault();
            }
            catch (SqlException sex)
            {
                throw new Exception(sex.Message);
            }
        }
    }
}
