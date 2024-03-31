using advise.webapi.core.InputModels;

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
