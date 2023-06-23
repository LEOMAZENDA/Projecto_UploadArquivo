namespace UploadArquivoAula.Models
{
    public class FileVM
    {
        public string Description { get; set; }
        public byte[] File { get; set; }
        public string ContentType { get; set; }
    }
}
