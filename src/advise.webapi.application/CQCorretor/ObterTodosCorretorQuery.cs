using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class ObterTodosCorretorQuery : IRequest<IEnumerable<CorretorViewModel>>
    {
    }
}
