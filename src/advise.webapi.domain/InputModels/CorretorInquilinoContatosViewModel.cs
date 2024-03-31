using System.ComponentModel.DataAnnotations;

namespace advise.webapi.api.InputModels
{
    public class CorretorInquilinoContatosViewModel
    {
        [Required(ErrorMessage = "A descrição do contato é obrigatória.")]
        public string DescricaoContato { get; set; }

        [Required(ErrorMessage = "O ID do Corretor é obrigatório.")]
        public Guid CorretorId { get; set; }

        [Required(ErrorMessage = "O ID do Corretor é obrigatório.")]
        public Guid InquilinoId { get; set; }
    }

}
