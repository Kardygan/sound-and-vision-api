using SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Models.Global.Mappers;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools.Connection.Database;

namespace SoundAndVision.API.Models.Global.Repositories
{
    public class AlbumRepository : IAlbumRepository<Album, AlbumFull>
    {
        private Connection _connection;

        public AlbumRepository(Connection connection)
        {
            _connection = connection;
        }

        public bool Add(Album album)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int id, Album album)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlbumFull> Get()
        {
            try
            {
                Command commandAlbums = new Command("SSP_GetAllAlbum", true);
                IEnumerable<int> ids = _connection.ExecuteReader(commandAlbums, albumData => (int)albumData["Id"]);

                List<AlbumFull> albums = new List<AlbumFull>();
                foreach (int id in ids)
                {
                    albums.Add(Get(id));
                }

                return albums;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlbumFull Get(int id)
        {
            try
            {
                Command commandAlbum = new Command("SSP_GetAlbumById", true);
                commandAlbum.AddParameter("@Id", id);

                Command commandAlbumArtists = new Command("SSP_GetAlbumArtistById", true);
                commandAlbumArtists.AddParameter("@Id", id);

                Command commandAlbumGenres = new Command("SSP_GetAlbumGenreById", true);
                commandAlbumGenres.AddParameter("@Id", id);

                Command commandAlbumTracks = new Command("SSP_GetAlbumTrackById", true);
                commandAlbumTracks.AddParameter("@Id", id);

                AlbumFull album = _connection.ExecuteReader(commandAlbum, albumData => albumData.ToAlbumFullGlobal()).SingleOrDefault();
                album.Artists = _connection.ExecuteReader(commandAlbumArtists, albumArtistsData => albumArtistsData.ToAlbumArtistGlobal());
                album.Genres = _connection.ExecuteReader(commandAlbumGenres, albumGenresData => albumGenresData.ToAlbumGenreGlobal());
                album.Tracks = _connection.ExecuteReader(commandAlbumTracks, albumTracksData => albumTracksData.ToAlbumTrackFullGlobal());

                return album;
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
