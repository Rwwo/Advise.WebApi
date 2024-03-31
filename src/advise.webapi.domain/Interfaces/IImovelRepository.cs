using advise.webapi.core.Models;

namespace advise.webapi.core.Interfaces
{
    public interface IImovelRepository : IRepository<Imovel>
    {
        Task<IEnumerable<Imovel>> ObterTodosComEnderecos();
        Task<Endereco> ObterEnderecoPorImovel(Guid imovelId);
        Task RemoverEnderecoImovel(Endereco endereco);
    }

}
