using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQCorretor
{
    public class ObterTodosCorretorQueryHandler : IRequestHandler<ObterTodosCorretorQuery, IEnumerable<CorretorViewModel>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterTodosCorretorQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CorretorViewModel>> Handle(ObterTodosCorretorQuery request, CancellationToken cancellationToken)
        {
            var resultDb = await _uow.CorretorRepository.ObterTodos();

            return _mapper.Map<List<CorretorViewModel>>(resultDb);

        }
    }
}
