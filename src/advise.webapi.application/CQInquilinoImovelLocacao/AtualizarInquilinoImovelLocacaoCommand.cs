using advise.webapi.core.InputModels;

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
