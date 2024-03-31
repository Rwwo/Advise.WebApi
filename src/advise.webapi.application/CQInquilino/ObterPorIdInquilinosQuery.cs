using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class ObterPorIdInquilinosQuery : IRequest<InquilinoViewModel>
    {
        public ObterPorIdInquilinosQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
