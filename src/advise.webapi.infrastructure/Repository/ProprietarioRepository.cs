using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.infrastructure.Context;

namespace advise.webapi.infrastructure.Repository
{
    public class ProprietarioRepository : Repository<Proprietario>, IProprietarioRepository
    {
        public ProprietarioRepository(ApiContext context) : base(context) { }
    }
}
