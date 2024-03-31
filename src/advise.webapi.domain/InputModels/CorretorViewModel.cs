using System.ComponentModel.DataAnnotations;

namespace advise.webapi.api.InputModels
{
    public class CorretorViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Status é obrigatório.")]
        public bool Status { get; set; }
    }

}
