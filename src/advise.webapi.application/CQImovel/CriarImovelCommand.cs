using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class CriarImovelCommand : IRequest<ImovelViewModel>
    {
        public CriarImovelCommand(ImovelViewModel imovel)
        {
            Imovel = imovel;
        }

        public ImovelViewModel Imovel { get; private set; }
    }
}
