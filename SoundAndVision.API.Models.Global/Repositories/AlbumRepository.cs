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
    public class AlbumRepository : IAlbumRepository<Album>
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

        public IEnumerable<Album> Get()
        {
            throw new NotImplementedException();
        }

        public Album Get(int id)
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

                Album album = _connection.ExecuteReader(commandAlbum, albumData => albumData.ToAlbumGlobal()).SingleOrDefault();
                album.Artists = _connection.ExecuteReader(commandAlbumArtists, albumArtistsData => albumArtistsData.ToArtistGlobal(true));
                album.Genres = _connection.ExecuteReader(commandAlbumGenres, albumGenresData => albumGenresData.ToGenreGlobal(true));
                album.Tracks = _connection.ExecuteReader(commandAlbumTracks, albumTracksData => albumTracksData.ToTrackGlobal());

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
