namespace advise.webapi.core.Models
{
    public class Imovel : Entity
    {
        public int QtdeQuartos { get; set; }
        public int QtdeBanheiros { get; set; }
        public int QtdeVagasGaragem { get; set; }
        public TipoImovel TipoImovel { get; set; }
        public PosicaoSolar PosicaoSolar { get; set; }
        public decimal Valor { get; set; }
        public string? Observacoes { get; set; }
        public Endereco Endereco { get; set; }
        public bool Status { get; set; }
        public Guid ProprietarioId { get; set; }

        /* ef */
        public ICollection<InquilinoImovelLocacao>? Locacoes { get; set; }
        public Proprietario? Proprietario { get; set; }
    }
}

