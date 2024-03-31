using advise.webapi.api.InputModels;
using advise.webapi.application.CQInquilino;

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
