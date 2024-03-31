namespace advise.webapi.core.Models
{
    public class CorretorProprietarioContatos : Entity
    {
        public string? DescricaoContato { get; set; }
        public Guid ProprietarioId { get; set; }
        public Guid CorretorId { get; set; }

        /* ef */
        public Proprietario? Proprietario { get; set; }
        public Corretor? Corretor { get; set; }
    }
}

