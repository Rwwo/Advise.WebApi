using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

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
