using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class AtualizarImovelCommand : IRequest<ImovelViewModel>
    {
        public AtualizarImovelCommand(ImovelViewModel imovel)
        {
            Imovel = imovel;
        }

        public ImovelViewModel Imovel { get; private set; }
    }
}
