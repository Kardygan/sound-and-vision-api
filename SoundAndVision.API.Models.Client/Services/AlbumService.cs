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
    public class AlbumService : IAlbumRepository<Album, AlbumFull>
    {
        private IAlbumRepository<GE.Album, GE.AlbumFull> _albumRepository;
        public AlbumService(IAlbumRepository<GE.Album, GE.AlbumFull> albumRepository)
        {
            _albumRepository = albumRepository;
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
                return _albumRepository.Get().Select(albumData => albumData.ToAlbumFullClient());
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
                return _albumRepository.Get(id).ToAlbumFullClient();
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
