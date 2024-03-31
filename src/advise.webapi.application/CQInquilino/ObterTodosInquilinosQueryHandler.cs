using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQInquilino
{
    public class ObterTodosInquilinosQueryHandler : IRequestHandler<ObterTodosInquilinosQuery, IEnumerable<InquilinoViewModel>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterTodosInquilinosQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<InquilinoViewModel>> Handle(ObterTodosInquilinosQuery request, CancellationToken cancellationToken)
        {
            var resultDb = await _uow.InquilinoRepository.ObterTodos();

            return _mapper.Map<List<InquilinoViewModel>>(resultDb);

        }
    }
}
