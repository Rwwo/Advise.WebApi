using advise.webapi.api.InputModels;
using advise.webapi.core.Models;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class AtualizarCorretorCommand : IRequest<CorretorViewModel>
    {
        public AtualizarCorretorCommand(CorretorViewModel corretor)
        {
            Corretor = corretor;
        }

        public CorretorViewModel Corretor { get; private set; }
    }
}
