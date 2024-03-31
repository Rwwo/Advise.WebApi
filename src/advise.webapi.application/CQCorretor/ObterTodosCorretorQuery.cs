using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class ObterTodosCorretorQuery : IRequest<IEnumerable<CorretorViewModel>>
    {
    }
}
