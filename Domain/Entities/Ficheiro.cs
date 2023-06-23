namespace Domain.Entities
{
    public class Ficheiro
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public byte[] Arquivo { get; set; }
        public string ContentType { get; set; }
    }
}
