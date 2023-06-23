namespace Application.ViewsModels
{
    public class FicheiroVM
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public byte[] Arquivo { get; set; }
        public string ContentType { get; set; }
    }
}
