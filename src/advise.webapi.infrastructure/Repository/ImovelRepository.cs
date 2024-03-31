using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.infrastructure.Context;

using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Repository
{
    public class ImovelRepository : Repository<Imovel>, IImovelRepository
    {
        public ImovelRepository(ApiContext context) : base(context) { }

        public async Task<IEnumerable<Imovel>> ObterTodosComEnderecos()
        {
            return await _dbContext.Imoveis.AsNoTracking().Include(p => p.Endereco).ToListAsync();
        }
        public async Task<Endereco> ObterEnderecoPorImovel(Guid imovelId)
        {
            return await _dbContext.Enderecos.AsNoTracking()
               .FirstOrDefaultAsync(c => c.Id == imovelId);
        }

        public async Task RemoverEnderecoImovel(Endereco endereco)
        {
            _dbContext.Enderecos.Remove(endereco);
            await SaveChanges();
        }
    }
}
