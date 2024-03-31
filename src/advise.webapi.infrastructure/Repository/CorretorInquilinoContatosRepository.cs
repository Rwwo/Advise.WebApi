using System.Linq.Expressions;

using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.infrastructure.Context;

namespace advise.webapi.infrastructure.Repository
{
    public class CorretorInquilinoContatosRepository : Repository<CorretorInquilinoContatos>, ICorretorInquilinoContatosRepository
    {
        public CorretorInquilinoContatosRepository(ApiContext context) : base(context) { }
    }
}
