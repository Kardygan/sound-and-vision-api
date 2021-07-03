using System;
using System.Collections.Generic;
using System.Text;

namespace SoundAndVision.API.Repositories.Interfaces
{
    public interface IAlbumRepository<TAlbum>
    {
        bool Add(TAlbum album);
        IEnumerable<TAlbum> Get();
        TAlbum Get(int id);
        bool Edit(int id, TAlbum album);
        bool Remove(int id);
    }
}
