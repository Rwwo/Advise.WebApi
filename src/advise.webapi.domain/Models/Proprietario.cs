namespace advise.webapi.core.Models
{
    public class Proprietario : Entity
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public bool Status { get; set; }


        /* ef */
        public ICollection<Imovel>? Imoveis { get; set; }
        public ICollection<CorretorProprietarioContatos>? ContatosCorretores { get; set; }

    }
}

