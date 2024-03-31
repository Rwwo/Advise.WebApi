using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class ObterPorIdImovelQuery : IRequest<ImovelViewModel>
    {
        public ObterPorIdImovelQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
