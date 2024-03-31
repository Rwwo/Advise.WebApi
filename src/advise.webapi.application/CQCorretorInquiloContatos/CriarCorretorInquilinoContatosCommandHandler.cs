using advise.webapi.api.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Models;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQCorretorInquiloContatos
{
    public class CriarCorretorInquilinoContatosCommandHandler : BaseService, IRequestHandler<CriarCorretorInquiloContatosCommand, CorretorInquilinoContatosViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CriarCorretorInquilinoContatosCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<CorretorInquilinoContatosViewModel> Handle(CriarCorretorInquiloContatosCommand request, CancellationToken cancellationToken)
        {
            var CorretorInquilinoContatosMap = _mapper.Map<CorretorInquilinoContatos>(request.CorretorInquilinoContatos);

            if (!ExecutarValidacao(new CorretorInquilinoContatosValidation(), CorretorInquilinoContatosMap))
                return request.CorretorInquilinoContatos;

            // Verifica se os IDs de corretor e inquilino existem no banco de dados
            var corretor = await _uow.CorretorRepository.ObterPorId(request.CorretorInquilinoContatos.CorretorId);
            if (corretor == null)
            {
                Notificar("Corretor não encontrado.");
                return request.CorretorInquilinoContatos;
            }

            var inquilino = await _uow.InquilinoRepository.ObterPorId(request.CorretorInquilinoContatos.InquilinoId);
            if (inquilino == null)
            {
                Notificar("Inquilino não encontrado.");
                return request.CorretorInquilinoContatos;
            }

            await _uow.CorretorInquilinoContatosRepository.Adicionar(CorretorInquilinoContatosMap);

            return request.CorretorInquilinoContatos;

        }
    }
}
