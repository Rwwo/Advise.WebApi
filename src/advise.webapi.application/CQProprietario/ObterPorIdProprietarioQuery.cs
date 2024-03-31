using advise.webapi.core.InputModels;

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
