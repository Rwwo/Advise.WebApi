using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.infrastructure.Context;

namespace advise.webapi.infrastructure.Repository
{
    public class InquilinoRepository : Repository<Inquilino>, IInquilinoRepository
    {
        public InquilinoRepository(ApiContext context) : base(context) { }
    }
}
