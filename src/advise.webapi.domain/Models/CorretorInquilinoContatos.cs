namespace advise.webapi.core.Models
{
    public class CorretorInquilinoContatos : Entity
    {
        public string? DescricaoContato { get; set; }
        public Guid CorretorId { get; set; }
        public Guid InquilinoId { get; set; }
        //public Guid InquilinoImovelLocacaoId { get;set; }


        /* ef */
        //public InquilinoImovelLocacao? InquilinoImovelLocacao { get; set; }
        public Corretor? Corretor { get; set; }
        public Inquilino? Inquilino { get; set; }        
    }
}

