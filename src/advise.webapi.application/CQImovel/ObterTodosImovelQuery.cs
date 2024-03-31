using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class ObterTodosImovelQuery : IRequest<IEnumerable<ImovelViewModel>>
    {
    }
}
