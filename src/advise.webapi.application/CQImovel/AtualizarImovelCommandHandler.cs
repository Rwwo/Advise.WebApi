using advise.webapi.api.InputModels;
using AutoMapper;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Models;
using advise.webapi.core.Services;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class AtualizarImovelCommandHandler : BaseService, IRequestHandler<AtualizarImovelCommand, ImovelViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public AtualizarImovelCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ImovelViewModel> Handle(AtualizarImovelCommand request, CancellationToken cancellationToken)
        {
            var ImovelMap = _mapper.Map<Imovel>(request.Imovel);

            if (!ExecutarValidacao(new ImovelValidation(), ImovelMap))
                return request.Imovel;

            await _uow.ImovelRepository.Atualizar(ImovelMap);

            await _uow.Commit();

            return request.Imovel;

        }
    }
}
