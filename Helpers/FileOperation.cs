using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Helpers
{
    public static class FileOperation
    {
        public static string UploadFile(IFormFile file, string FolderPath)
        {
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "./wwwroot\\Files\\Images", FolderPath, fileName);
            using (var stream = System.IO.File.Create(filePath))
            {
                file.CopyTo(stream);
            }
            return fileName;
        }




    }

}
