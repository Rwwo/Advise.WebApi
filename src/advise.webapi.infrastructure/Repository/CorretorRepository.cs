using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.infrastructure.Context;

namespace advise.webapi.infrastructure.Repository
{
    public class CorretorRepository : Repository<Corretor>, ICorretorRepository
    {
        public CorretorRepository(ApiContext context) : base(context) { }
    }
}
