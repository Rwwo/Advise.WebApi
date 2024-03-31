using System.ComponentModel.DataAnnotations;

using advise.webapi.core.Models;

namespace advise.webapi.api.InputModels
{
    public class ImovelViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo QtdeQuartos é obrigatório.")]
        public int QtdeQuartos { get; set; }

        [Required(ErrorMessage = "O campo QtdeBanheiros é obrigatório.")]
        public int QtdeBanheiros { get; set; }

        [Required(ErrorMessage = "O campo QtdeVagasGaragem é obrigatório.")]
        public int QtdeVagasGaragem { get; set; }

        [Required(ErrorMessage = "O campo TipoImovel é obrigatório.")]
        public TipoImovel TipoImovel { get; set; }

        [Required(ErrorMessage = "O campo PosicaoSolar é obrigatório.")]
        public PosicaoSolar PosicaoSolar { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O campo Valor deve ser um número positivo.")]
        public decimal Valor { get; set; }

        public string Observacoes { get; set; }

        [Required(ErrorMessage = "O campo Proprietario é obrigatório.")]
        public Guid ProprietarioId { get; set; }    

        public EnderecoViewModel Endereco { get; set; }

        [Required(ErrorMessage = "O campo Status é obrigatório.")]
        public bool Status { get; set; }
    }

}
