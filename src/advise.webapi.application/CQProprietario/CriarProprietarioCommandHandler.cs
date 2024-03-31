using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class CriarProprietarioCommandHandler : BaseService, IRequestHandler<CriarProprietarioCommand, ProprietarioViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CriarProprietarioCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ProprietarioViewModel> Handle(CriarProprietarioCommand request, CancellationToken cancellationToken)
        {
            var ProprietarioMap = _mapper.Map<Proprietario>(request.Proprietario);

            if (!ExecutarValidacao(new ProprietarioValidation(), ProprietarioMap))
                return request.Proprietario;

            await _uow.ProprietarioRepository.Adicionar(ProprietarioMap);

            return request.Proprietario;

        }
    }
}
