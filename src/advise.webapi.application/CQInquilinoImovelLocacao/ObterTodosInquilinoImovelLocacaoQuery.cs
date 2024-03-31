using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

using MediatR;

namespace advise.webapi.application.CQInquilinoImovelLocacao
{
    public class ObterTodosInquilinoImovelLocacaoQuery : IRequest<IEnumerable<InquilinoImovelLocacaoViewModel>>
    {
    }
}
