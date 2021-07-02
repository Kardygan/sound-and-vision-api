using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoundAndVision.API.Infrastructure
{
    public static class ImageUpload
    {
        public enum ImageFolder
        {
            Albums,
            Artists,
            Avatars,
            Labels
        }

        public async static Task<string> UploadImage(IFormFile file, ImageFolder imageFolder)
        {
            if (file != null)
            {
                string imagePath = MakeImagePath(file.FileName, imageFolder.ToString());

                using (FileStream fs = new FileStream(imagePath, FileMode.Create))
                {
                    await file.CopyToAsync(fs);
                }

                return imagePath;
            }

            return null;
        }

        private static string MakeImagePath(string imageName, string imageFolder)
        {
            string mainFolder = "Uploads";
            if (!Directory.Exists(mainFolder))
                Directory.CreateDirectory(mainFolder);

            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), mainFolder, "/", imageFolder);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string fileName = DateTime.Now.Millisecond + imageName;

            return Path.Combine(folderPath, "/", fileName);
        }
    }
}
