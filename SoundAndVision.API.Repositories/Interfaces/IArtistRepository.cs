using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Repositories.Interfaces
{
    public interface IArtistRepository<TArtist>
    {
        bool Add(TArtist artist);
        TArtist GetAll();
        TArtist Get(int id);
        bool Edit(int id, TArtist artist);
        bool Remove(int id);
    }
}
