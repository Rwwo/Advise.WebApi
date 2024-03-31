using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.infrastructure.Context;

namespace advise.webapi.infrastructure.Repository
{
    public class CorretorProprietarioContatosRepository : Repository<CorretorProprietarioContatos>, ICorretorProprietarioContatosRepository
    {
        public CorretorProprietarioContatosRepository(ApiContext context) : base(context) { }
    }
}
