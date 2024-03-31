using advise.webapi.api.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class ObterPorIdCorretorQueryHandler : IRequestHandler<ObterPorIdCorretorQuery, CorretorViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterPorIdCorretorQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<CorretorViewModel> Handle(ObterPorIdCorretorQuery request, CancellationToken cancellationToken)
        {

            var resultDb = await _uow.CorretorRepository.ObterPorId(request.Id);

            return _mapper.Map<CorretorViewModel>(resultDb);

        }
    }
}
