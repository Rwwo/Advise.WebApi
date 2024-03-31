using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class ObterTodosProprietarioQuery : IRequest<IEnumerable<ProprietarioViewModel>>
    {
    }
}
