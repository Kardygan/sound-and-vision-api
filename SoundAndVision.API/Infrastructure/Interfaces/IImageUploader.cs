using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Infrastructure.Interfaces
{
    public enum ImageFolder
    {
        Albums,
        Artists,
        Avatars,
        Labels
    }

    public interface IImageUploader
    {
        Task<string> UploadImage(HttpRequest req, ImageFolder imageFolder);
        string MakeImagePath(string imageName, string imageFolder);
    }
}
