using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class CriarCorretorCommandHandler : BaseService, IRequestHandler<CriarCorretorCommand, CorretorViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CriarCorretorCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<CorretorViewModel> Handle(CriarCorretorCommand request, CancellationToken cancellationToken)
        {
            var corretorMap = _mapper.Map<Corretor>(request.Corretor);

            if (!ExecutarValidacao(new CorretorValidation(), corretorMap))
                return request.Corretor;

            await _uow.CorretorRepository.Adicionar(corretorMap);

            return request.Corretor;

        }
    }
}
