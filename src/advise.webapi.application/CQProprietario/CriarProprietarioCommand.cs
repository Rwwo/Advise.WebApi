using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class CriarProprietarioCommand : IRequest<ProprietarioViewModel>
    {
        public CriarProprietarioCommand(ProprietarioViewModel proprietario)
        {
            Proprietario = proprietario;
        }

        public ProprietarioViewModel Proprietario { get; private set; }
    }
}
