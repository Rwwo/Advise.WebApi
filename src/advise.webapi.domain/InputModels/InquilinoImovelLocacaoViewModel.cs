using System.ComponentModel.DataAnnotations;

namespace advise.webapi.core.InputModels
{
    public class InquilinoImovelLocacaoViewModel
    {
        [Required(ErrorMessage = "O campo DataEntrada é obrigatório.")]
        public DateTime DataEntrada { get; set; }

        public DateTime? DataSaida { get; set; }

        [Required(ErrorMessage = "O ID do Contato com corretor é obrigatório.")]
        public Guid AtendimentoCorretorId { get; set; }

        [Required(ErrorMessage = "O ID do Inquilino é obrigatório.")]
        public Guid InquilinoId { get; set; }

        [Required(ErrorMessage = "O ID do Imovel é obrigatório.")]
        public Guid ImovelId { get; set; }

    }

}
