using advise.webapi.core.InputModels;

using MediatR;

namespace advise.webapi.application.CQCorretorProprietarioContatos
{
    public class CriarCorretorProprietarioContatosCommand : IRequest<CorretorProprietarioContatosViewModel>
    {
        public CriarCorretorProprietarioContatosCommand(CorretorProprietarioContatosViewModel corretorProprietarioContatos)
        {
            CorretorProprietarioContatos = corretorProprietarioContatos;
        }

        public CorretorProprietarioContatosViewModel CorretorProprietarioContatos { get; private set; }
    }
}
