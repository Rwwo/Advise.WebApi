using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQCorretorProprietarioContatos
{
    public class CriarCorretorProprietarioContatosCommandHandler : BaseService, IRequestHandler<CriarCorretorProprietarioContatosCommand, CorretorProprietarioContatosViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CriarCorretorProprietarioContatosCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<CorretorProprietarioContatosViewModel> Handle(CriarCorretorProprietarioContatosCommand request, CancellationToken cancellationToken)
        {
            var corretorProprietarioContatosMap = _mapper.Map<CorretorProprietarioContatos>(request.CorretorProprietarioContatos);

            if (!ExecutarValidacao(new CorretorProprietarioContatosValidation(), corretorProprietarioContatosMap))
                return request.CorretorProprietarioContatos;

            // Verifica se os IDs de corretor e inquilino existem no banco de dados
            var corretor = await _uow.CorretorRepository.ObterPorId(request.CorretorProprietarioContatos.CorretorId);
            if (corretor == null)
            {
                Notificar("Corretor não encontrado.");
                return request.CorretorProprietarioContatos;
            }

            var inquilino = await _uow.ProprietarioRepository.ObterPorId(request.CorretorProprietarioContatos.ProprietarioId);
            if (inquilino == null)
            {
                Notificar("Inquilino não encontrado.");
                return request.CorretorProprietarioContatos;
            }

            await _uow.CorretorProprietarioContatosRepository.Adicionar(corretorProprietarioContatosMap);

            return request.CorretorProprietarioContatos;

        }
    }
}
