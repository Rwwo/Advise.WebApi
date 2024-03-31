using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class AtualizarInquilinosCommandHandler : BaseService, IRequestHandler<AtualizarInquilinosCommand, InquilinoViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public AtualizarInquilinosCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<InquilinoViewModel> Handle(AtualizarInquilinosCommand request, CancellationToken cancellationToken)
        {
            var inquilinoMap = _mapper.Map<Inquilino>(request.Inquilino);

            if (!ExecutarValidacao(new InquilinoValidation(), inquilinoMap))
                return request.Inquilino;

            await _uow.InquilinoRepository.Atualizar(inquilinoMap);

            await _uow.Commit();

            return request.Inquilino;

        }
    }
}
