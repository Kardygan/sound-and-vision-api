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
                Command command = new Command("SSP_CreateArtist", true);
                command.AddParameter("@Name", artist.Name);
                command.AddParameter("@Picture", artist.Picture);
                command.AddParameter("@Alias", artist.Alias);
                command.AddParameter("@StartDate", artist.StartDate);
                command.AddParameter("@EndDate", artist.EndDate);
                command.AddParameter("@Description", artist.Description);

                return _connection.ExecuteNonQuery(command) == 1;
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

        public IEnumerable<Artist> Get()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
