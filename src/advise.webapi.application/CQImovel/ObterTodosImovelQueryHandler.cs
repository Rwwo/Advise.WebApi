using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQImovel
{
    public class ObterTodosImovelQueryHandler : IRequestHandler<ObterTodosImovelQuery, IEnumerable<ImovelViewModel>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterTodosImovelQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ImovelViewModel>> Handle(ObterTodosImovelQuery request, CancellationToken cancellationToken)
        {
            var resultDb = await _uow.ImovelRepository.ObterTodosComEnderecos();

            return _mapper.Map<List<ImovelViewModel>>(resultDb);

        }
    }
}
