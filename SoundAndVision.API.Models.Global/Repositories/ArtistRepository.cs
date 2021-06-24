using SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Tools.Connection.Database;

namespace SoundAndVision.API.Models.Global.Repositories
{
    public class ArtistRepository : IArtistRepository<Artist>
    {
        private Connection _connection;

        public ArtistRepository(Connection connection)
        {
            _connection = connection;
        }

        public bool Add(Artist artist)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (SqlException sex)
            {
                throw new Exception(sex.Message);
            }
        }

        public bool Edit(int id, Artist artist)
        {
            throw new NotImplementedException();
        }

        public Artist Get(int id)
        {
            throw new NotImplementedException();
        }

        public Artist GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
