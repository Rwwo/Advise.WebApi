using advise.webapi.api.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class AtualizarInquilinosCommand : IRequest<InquilinoViewModel>
    {
        public AtualizarInquilinosCommand(InquilinoViewModel inquilino)
        {
            Inquilino = inquilino;
        }

        public InquilinoViewModel Inquilino { get; private set; }
    }
}
