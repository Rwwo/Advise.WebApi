using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

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
