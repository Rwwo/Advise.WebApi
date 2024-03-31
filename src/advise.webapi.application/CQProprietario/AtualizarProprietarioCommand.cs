using advise.webapi.api.InputModels;
using advise.webapi.core.Models;

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
