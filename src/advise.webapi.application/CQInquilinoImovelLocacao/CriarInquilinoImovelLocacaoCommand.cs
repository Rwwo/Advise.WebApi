using advise.webapi.api.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilinoImovelLocacao
{
    public class CriarInquilinoImovelLocacaoCommand : IRequest<InquilinoImovelLocacaoViewModel>
    {
        public CriarInquilinoImovelLocacaoCommand(InquilinoImovelLocacaoViewModel inquilinoImovelLocacao)
        {
            InquilinoImovelLocacao = inquilinoImovelLocacao;
        }

        public InquilinoImovelLocacaoViewModel InquilinoImovelLocacao { get; private set; }
    }
}
