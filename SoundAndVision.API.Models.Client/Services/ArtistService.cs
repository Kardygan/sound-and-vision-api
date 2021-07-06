using SoundAndVision.API.Models.Client.Entities;
using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SoundAndVision.API.Models.Client.Mappers;

namespace SoundAndVision.API.Models.Client.Services
{
    public class ArtistService : IArtistRepository<Artist>
    {
        private IArtistRepository<GE.Artist> _artistRepository;

        public ArtistService(IArtistRepository<GE.Artist> artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public bool Add(Artist artist)
        {
            try
            {
                return _artistRepository.Add(artist.ToArtistGlobal());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
