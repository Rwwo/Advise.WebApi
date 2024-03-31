using advise.webapi.core.Interfaces;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class DeletarImovelCommandHandler : BaseService, IRequestHandler<DeletarImovelCommand, bool>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public DeletarImovelCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeletarImovelCommand request, CancellationToken cancellationToken)
        {
            var Imovel = await _uow.ImovelRepository.ObterPorId(request.Id);

            if (Imovel == null)
            {
                Notificar("Imovel não encontrado");
                return false;
            }

            Imovel.Deletar();

            await _uow.ImovelRepository.Atualizar(Imovel);

            return true;

        }
    }
}
