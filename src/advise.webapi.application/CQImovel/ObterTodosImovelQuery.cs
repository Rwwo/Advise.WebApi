using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class ObterTodosImovelQuery : IRequest<IEnumerable<ImovelViewModel>>
    {
    }
}
