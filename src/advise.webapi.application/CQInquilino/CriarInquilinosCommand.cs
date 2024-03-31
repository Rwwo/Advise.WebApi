using advise.webapi.api.InputModels;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class CriarInquilinosCommand : IRequest<InquilinoViewModel>
    {
        public CriarInquilinosCommand(InquilinoViewModel inquilino)
        {
            Inquilino = inquilino;
        }

        public InquilinoViewModel Inquilino { get; private set; }
    }
}
