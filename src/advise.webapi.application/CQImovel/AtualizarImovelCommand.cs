using advise.webapi.api.InputModels;

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
