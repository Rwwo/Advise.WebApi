using advise.webapi.api.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Models;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class CriarImovelCommandHandler : BaseService, IRequestHandler<CriarImovelCommand, ImovelViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CriarImovelCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ImovelViewModel> Handle(CriarImovelCommand request, CancellationToken cancellationToken)
        {
            var ImovelMap = _mapper.Map<Imovel>(request.Imovel);

            if (!ExecutarValidacao(new ImovelValidation(), ImovelMap))
                return request.Imovel;

            await _uow.ImovelRepository.Adicionar(ImovelMap);

            return request.Imovel;

        }
    }
}
