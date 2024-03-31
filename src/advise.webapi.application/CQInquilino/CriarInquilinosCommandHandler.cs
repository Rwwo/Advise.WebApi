using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class CriarInquilinosCommandHandler : BaseService, IRequestHandler<CriarInquilinosCommand, InquilinoViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CriarInquilinosCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<InquilinoViewModel> Handle(CriarInquilinosCommand request, CancellationToken cancellationToken)
        {
            var inquilinoMap = _mapper.Map<Inquilino>(request.Inquilino);

            if (!ExecutarValidacao(new InquilinoValidation(), inquilinoMap))
                return request.Inquilino;

            await _uow.InquilinoRepository.Adicionar(inquilinoMap);

            return request.Inquilino;

        }
    }
}
