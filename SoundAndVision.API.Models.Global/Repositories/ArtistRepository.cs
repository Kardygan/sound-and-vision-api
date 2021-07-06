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
            catch (Exception)
            {
                throw new Exception("Artist could not be added!");
            }
        }

        public bool Edit(int id, Artist artist)
        {
            throw new NotImplementedException();
        }

        public Artist Get(int id)
        {
            try
            {
                Command commandArtist = new Command("SSP_GetArtistById", true);
                commandArtist.AddParameter("@Id", id);

                return _connection.ExecuteReader(commandArtist, artistData => artistData.ToArtistGlobal()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Artist> Get()
        {
            try
            {
                Command commandArtist = new Command("SSP_GetAllArtist", true);

                return _connection.ExecuteReader(commandArtist, artistData => artistData.ToArtistGlobal());
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
