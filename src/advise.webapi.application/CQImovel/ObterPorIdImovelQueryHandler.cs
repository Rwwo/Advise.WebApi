using advise.webapi.api.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class ObterPorIdImovelQueryHandler : IRequestHandler<ObterPorIdImovelQuery, ImovelViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterPorIdImovelQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ImovelViewModel> Handle(ObterPorIdImovelQuery request, CancellationToken cancellationToken)
        {

            var resultDb = await _uow.ImovelRepository.ObterEnderecoPorImovel(request.Id);

            return _mapper.Map<ImovelViewModel>(resultDb);

        }
    }
}
