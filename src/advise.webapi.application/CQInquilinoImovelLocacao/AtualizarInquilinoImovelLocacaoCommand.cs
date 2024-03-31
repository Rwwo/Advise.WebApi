using advise.webapi.api.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilinoImovelLocacao
{
    public class AtualizarInquilinoImovelLocacaoCommand : IRequest<InquilinoImovelLocacaoViewModel>
    {
        public AtualizarInquilinoImovelLocacaoCommand(InquilinoImovelLocacaoViewModel inquilinoImovelLocacao)
        {
            InquilinoImovelLocacao = inquilinoImovelLocacao;
        }

        public InquilinoImovelLocacaoViewModel InquilinoImovelLocacao { get; private set; }
    }
}
