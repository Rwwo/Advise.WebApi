using advise.webapi.core.Models;

namespace advise.webapi.core.InputModels
{
    public class ImovelDetalhadoViewModel
    {
        public Guid Id { get; set; }

        public int QtdeQuartos { get; set; }

        public int QtdeBanheiros { get; set; }

        public int QtdeVagasGaragem { get; set; }

        public TipoImovel TipoImovel { get; set; }

        public PosicaoSolar PosicaoSolar { get; set; }

        public decimal Valor { get; set; }

        public string Observacoes { get; set; }

        public ProprietarioViewModel Proprietario { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public bool Status { get; set; }
    }
}
