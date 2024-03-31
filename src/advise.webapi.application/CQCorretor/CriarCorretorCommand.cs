using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class CriarCorretorCommand : IRequest<CorretorViewModel>
    {
        public CriarCorretorCommand(CorretorViewModel corretor)
        {
            Corretor = corretor;
        }

        public CorretorViewModel Corretor { get; private set; }
    }
}
