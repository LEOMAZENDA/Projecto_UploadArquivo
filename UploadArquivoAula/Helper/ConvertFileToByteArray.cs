using Microsoft.AspNetCore.Http;
using System.IO;
using UploadArquivoAula.Models;

namespace UploadArquivoAula.Helper
{
    public static class ConvertFileToByteArray
    {
        public static FileVM Convert(IFormFile file)
        {
            FileVM vM = null;

            if (file == null) return null;

            using (var ms = new MemoryStream())
            {
                file.OpenReadStream().CopyTo(ms);
                vM = new FileVM()
                {
                    Description = file.FileName,
                    File = ms.ToArray(),
                    ContentType = file.ContentType,
                };
            }

            return vM;
        }
    }
}
