using advise.webapi.api.InputModels;
using AutoMapper;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Models;
using advise.webapi.core.Services;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class AtualizarCorretorCommandHandler : BaseService, IRequestHandler<AtualizarCorretorCommand, CorretorViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public AtualizarCorretorCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<CorretorViewModel> Handle(AtualizarCorretorCommand request, CancellationToken cancellationToken)
        {
            var corretorMap = _mapper.Map<Corretor>(request.Corretor);

            if (!ExecutarValidacao(new CorretorValidation(), corretorMap))
                return request.Corretor;

            await _uow.CorretorRepository.Atualizar(corretorMap);

            await _uow.Commit();

            return request.Corretor;

        }
    }
}
