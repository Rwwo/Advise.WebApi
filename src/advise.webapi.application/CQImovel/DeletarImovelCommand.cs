using MediatR;

namespace advise.webapi.application.CQImovel
{

    public class DeletarImovelCommand : IRequest<bool>
    {
        public DeletarImovelCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}
