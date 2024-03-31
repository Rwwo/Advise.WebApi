namespace advise.webapi.core.Models
{
    public class Corretor : Entity
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public bool Status { get; set; }

        /* ef */
        public ICollection<CorretorProprietarioContatos>? ContatosProprietarios { get; set; }
        public ICollection<CorretorInquilinoContatos>? AtendimentosInquilinos { get; set; }
    }


}

