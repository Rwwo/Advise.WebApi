using advise.webapi.api.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQInquilinoImovelLocacao
{
    public class ObterTodosInquilinoImovelLocacaoQueryHandler : IRequestHandler<ObterTodosInquilinoImovelLocacaoQuery, IEnumerable<InquilinoImovelLocacaoViewModel>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterTodosInquilinoImovelLocacaoQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<InquilinoImovelLocacaoViewModel>> Handle(ObterTodosInquilinoImovelLocacaoQuery request, CancellationToken cancellationToken)
        {
            var resultDb = await _uow.InquilinoImovelLocacaoRepository.ObterTodosComDadosAdicionais();

            var mapp = _mapper.Map<List<InquilinoImovelLocacaoViewModel>>(resultDb);

            return mapp;

        }
    }
}
