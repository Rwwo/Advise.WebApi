using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class ObterPorIdCorretorQuery : IRequest<CorretorViewModel>
    {
        public ObterPorIdCorretorQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
