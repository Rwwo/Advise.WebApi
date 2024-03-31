using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class AtualizarProprietarioCommand : IRequest<ProprietarioViewModel>
    {
        public AtualizarProprietarioCommand(ProprietarioViewModel proprietario)
        {
            Proprietario = proprietario;
        }

        public ProprietarioViewModel Proprietario { get; private set; }
    }
}
