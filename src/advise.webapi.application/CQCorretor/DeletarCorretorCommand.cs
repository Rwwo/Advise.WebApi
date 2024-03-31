using MediatR;

namespace advise.webapi.application.CQCorretor
{

    public class DeletarCorretorCommand : IRequest<bool>
    {
        public DeletarCorretorCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}
