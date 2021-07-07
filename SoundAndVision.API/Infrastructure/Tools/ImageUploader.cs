using Microsoft.AspNetCore.Http;
using SoundAndVision.API.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Infrastructure.Tools
{
    public class ImageUploader : IImageUploader
    {
        public string MakeImagePath(string imageName, string imageFolder)
        {
            string mainFolder = "Uploads/";
            if (!Directory.Exists(mainFolder))
                Directory.CreateDirectory(mainFolder);

            string folderPath = Path.Combine(mainFolder, imageFolder);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            folderPath = folderPath + "/";

            string fileName = DateTime.Now.Millisecond + imageName;

            return Path.Combine(folderPath, fileName);
        }

        public async Task<string> UploadImage(HttpRequest req, ImageFolder imageFolder)
        {
            string imagePath = MakeImagePath(req.Form.Files[0].FileName, imageFolder.ToString());

            using (FileStream fs = new FileStream(imagePath, FileMode.Create))
            {
                await req.Form.Files[0].CopyToAsync(fs);
            }

            return imagePath;
        }
    }
}
