using advise.webapi.core.Models;

namespace advise.webapi.core.Interfaces
{
    public interface IInquilinoImovelLocacaoRepository : IRepository<InquilinoImovelLocacao>
    {
        Task<IEnumerable<InquilinoImovelLocacao>> ObterTodosComDadosAdicionais();
    }

}
