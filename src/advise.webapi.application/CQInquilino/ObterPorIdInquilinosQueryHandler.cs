using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class ObterPorIdInquilinosQueryHandler : IRequestHandler<ObterPorIdInquilinosQuery, InquilinoViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterPorIdInquilinosQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<InquilinoViewModel> Handle(ObterPorIdInquilinosQuery request, CancellationToken cancellationToken)
        {

            var resultDb = await _uow.InquilinoRepository.ObterPorId(request.Id);

            return _mapper.Map<InquilinoViewModel>(resultDb);

        }
    }
}
