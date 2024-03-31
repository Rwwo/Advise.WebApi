using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQCorretorInquiloContatos
{
    public class CriarCorretorInquiloContatosCommand : IRequest<CorretorInquilinoContatosViewModel>
    {
        public CriarCorretorInquiloContatosCommand(CorretorInquilinoContatosViewModel corretorInquilinoContatosViewModel)
        {
            CorretorInquilinoContatos = corretorInquilinoContatosViewModel;
        }

        public CorretorInquilinoContatosViewModel CorretorInquilinoContatos { get; private set; }
    }
}
