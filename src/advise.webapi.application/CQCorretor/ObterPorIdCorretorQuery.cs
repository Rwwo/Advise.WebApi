using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

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
