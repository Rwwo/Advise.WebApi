using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class DeletarInquilinosCommand : IRequest<bool>
    {
        public DeletarInquilinosCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}
