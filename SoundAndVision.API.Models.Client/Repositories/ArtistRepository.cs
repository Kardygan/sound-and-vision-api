﻿using SoundAndVision.API.Models.Client.Entities;
using GE = SoundAndVision.API.Models.Global.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SoundAndVision.API.Models.Client.Mappers;

namespace SoundAndVision.API.Models.Client.Repositories
{
    public class ArtistRepository : IArtistRepository<Artist>
    {
        private IArtistRepository<GE.Artist> _artistRepositoryGlobal;

        public ArtistRepository(IArtistRepository<GE.Artist> artistRepositoryGlobal)
        {
            _artistRepositoryGlobal = artistRepositoryGlobal;
        }

        public bool Add(Artist artist)
        {
            try
            {
                return _artistRepositoryGlobal.Add(artist.ToArtistGlobal());
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
