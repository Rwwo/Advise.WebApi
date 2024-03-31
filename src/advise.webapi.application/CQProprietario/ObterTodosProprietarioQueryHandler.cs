using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class ObterTodosProprietarioQueryHandler : IRequestHandler<ObterTodosProprietarioQuery, IEnumerable<ProprietarioViewModel>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterTodosProprietarioQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProprietarioViewModel>> Handle(ObterTodosProprietarioQuery request, CancellationToken cancellationToken)
        {
            var resultDb = await _uow.ProprietarioRepository.ObterTodos();

            return _mapper.Map<List<ProprietarioViewModel>>(resultDb);

        }
    }
}
