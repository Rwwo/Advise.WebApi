using MediatR;

namespace advise.webapi.application.CQProprietario
{

    public class DeletarProprietarioCommand : IRequest<bool>
    {
        public DeletarProprietarioCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}
