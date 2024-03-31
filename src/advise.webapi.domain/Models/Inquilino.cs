namespace advise.webapi.core.Models
{
    public class Inquilino : Entity
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public bool Status { get; set; }

        /* ef */
        public ICollection<CorretorInquilinoContatos>? AtendimentosCorretores { get; set; }
        public ICollection<InquilinoImovelLocacao>? Locacoes { get; set; }
    }
}

