using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class ObterTodosProprietarioQuery : IRequest<IEnumerable<ProprietarioViewModel>>
    {
    }
}
