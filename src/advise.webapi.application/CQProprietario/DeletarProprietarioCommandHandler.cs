using advise.webapi.core.Interfaces;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class DeletarProprietarioCommandHandler : BaseService, IRequestHandler<DeletarProprietarioCommand, bool>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public DeletarProprietarioCommandHandler (IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeletarProprietarioCommand request, CancellationToken cancellationToken)
        {
            var Proprietario = await _uow.ProprietarioRepository.ObterPorId(request.Id);

            if (Proprietario == null)
            {
                Notificar("Proprietario não encontrado");
                return false;
            }

            Proprietario.Deletar();

            await _uow.ProprietarioRepository.Atualizar(Proprietario);

            return true;

        }
    }
}
