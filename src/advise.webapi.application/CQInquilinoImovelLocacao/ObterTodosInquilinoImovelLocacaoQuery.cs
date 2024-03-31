using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilinoImovelLocacao
{
    public class ObterTodosInquilinoImovelLocacaoQuery : IRequest<IEnumerable<InquilinoImovelLocacaoDetalhadaViewModel>>
    {
    }
}
