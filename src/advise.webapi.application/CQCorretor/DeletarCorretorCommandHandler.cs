using advise.webapi.core.Interfaces;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class DeletarCorretorCommandHandler : BaseService, IRequestHandler<DeletarCorretorCommand, bool>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public DeletarCorretorCommandHandler (IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeletarCorretorCommand request, CancellationToken cancellationToken)
        {
            var corretor = await _uow.CorretorRepository.ObterPorId(request.Id);

            if (corretor == null)
            {
                Notificar("Corretor não encontrado");
                return false;
            }

            corretor.Deletar();

            await _uow.CorretorRepository.Atualizar(corretor);

            return true;

        }
    }
}
