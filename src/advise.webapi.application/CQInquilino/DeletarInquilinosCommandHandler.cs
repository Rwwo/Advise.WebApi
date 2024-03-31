using advise.webapi.core.Interfaces;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class DeletarInquilinosCommandHandler : BaseService, IRequestHandler<DeletarInquilinosCommand, bool>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public DeletarInquilinosCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeletarInquilinosCommand request, CancellationToken cancellationToken)
        {
            var inquilino = await _uow.InquilinoRepository.ObterPorId(request.Id);

            if (inquilino == null)
            {
                Notificar("Inquilino não encontrado");
                return false;
            }

            inquilino.Deletar();

            await _uow.InquilinoRepository.Atualizar(inquilino);

            return true;

        }
    }
}
