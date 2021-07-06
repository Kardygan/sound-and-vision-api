using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Repositories.Interfaces
{
    public interface IAlbumRepository<TAlbum, TAlbumFull>
    {
        bool Add(TAlbum album);
        IEnumerable<TAlbumFull> Get();
        TAlbumFull Get(int id);
        bool Edit(int id, TAlbum album);
        bool Remove(int id);
    }
}
