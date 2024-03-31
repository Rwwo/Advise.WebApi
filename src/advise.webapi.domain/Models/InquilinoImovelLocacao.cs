namespace advise.webapi.core.Models
{
    public class InquilinoImovelLocacao : Entity
    {
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }

        public Guid AtendimentoCorretorId { get; set; }
        public Guid InquilinoId { get; set; }
        public Guid ImovelId { get; set; }


        /* ef */
        public CorretorInquilinoContatos? AtendimentoCorretor { get; set; }
        public Inquilino? Inquilino { get; set; }
        public Imovel? Imovel { get; set; }

    }
}

