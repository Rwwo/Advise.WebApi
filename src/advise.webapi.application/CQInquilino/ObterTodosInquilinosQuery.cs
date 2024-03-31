using advise.webapi.api.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class ObterTodosInquilinosQuery : IRequest<IEnumerable<InquilinoViewModel>>
    {
    }
}
