using Microsoft.AspNetCore.Http;

using System.Drawing;
using System.Drawing.Imaging;

namespace Helpers
{
    public static class FileOperation
    {
        public static string? UploadImage(Image image, string folderPath)
        {
            if (image == null)
                return null;

            var fileName = Guid.NewGuid().ToString() + ".jpg";
            var saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "./wwwroot\\Files\\Images", folderPath);

            if (!Directory.Exists(saveDirectory))
                Directory.CreateDirectory(saveDirectory);

            var savePath = Path.Combine(saveDirectory, fileName);

            image.Save(savePath, ImageFormat.Jpeg);

            return fileName; 
        }





    }

}
