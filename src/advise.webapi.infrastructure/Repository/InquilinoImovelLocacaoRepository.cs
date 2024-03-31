using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.infrastructure.Context;

using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Repository
{
    public class InquilinoImovelLocacaoRepository : Repository<InquilinoImovelLocacao>, IInquilinoImovelLocacaoRepository
    {
        public InquilinoImovelLocacaoRepository(ApiContext context) : base(context) { }

        public async Task<IEnumerable<InquilinoImovelLocacao>> ObterTodosComDadosAdicionais()
        {

            return await _dbContext.InquilinoImovelLocacoes.AsNoTracking()
                .Include(i => i.Inquilino)
                .Include(i => i.Imovel)
                .Include(c => c.AtendimentoCorretor)
                .Include(cor => cor.AtendimentoCorretor.Corretor)
                .Include(p => p.Imovel.Proprietario)
                .ToListAsync();
        }
    }
}
