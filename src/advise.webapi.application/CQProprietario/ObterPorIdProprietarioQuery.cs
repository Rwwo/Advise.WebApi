using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class ObterPorIdProprietarioQuery : IRequest<ProprietarioViewModel>
    {
        public ObterPorIdProprietarioQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
