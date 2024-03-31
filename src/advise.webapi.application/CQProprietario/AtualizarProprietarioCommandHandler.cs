using advise.webapi.api.InputModels;
using AutoMapper;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Models;
using advise.webapi.core.Services;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class AtualizarProprietarioCommandHandler : BaseService, IRequestHandler<AtualizarProprietarioCommand, ProprietarioViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public AtualizarProprietarioCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ProprietarioViewModel> Handle(AtualizarProprietarioCommand request, CancellationToken cancellationToken)
        {
            var ProprietarioMap = _mapper.Map<Proprietario>(request.Proprietario);

            if (!ExecutarValidacao(new ProprietarioValidation(), ProprietarioMap))
                return request.Proprietario;

            await _uow.ProprietarioRepository.Atualizar(ProprietarioMap);

            await _uow.Commit();

            return request.Proprietario;

        }
    }
}
