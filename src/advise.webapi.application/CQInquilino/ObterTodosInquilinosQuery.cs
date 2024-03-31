using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class ObterTodosInquilinosQuery : IRequest<IEnumerable<InquilinoViewModel>>
    {
    }
}
