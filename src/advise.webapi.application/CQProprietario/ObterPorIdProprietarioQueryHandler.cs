using advise.webapi.api.InputModels;
using advise.webapi.core.Interfaces;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQProprietario
{
    public class ObterPorIdProprietarioQueryHandler : IRequestHandler<ObterPorIdProprietarioQuery, ProprietarioViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ObterPorIdProprietarioQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ProprietarioViewModel> Handle(ObterPorIdProprietarioQuery request, CancellationToken cancellationToken)
        {

            var resultDb = await _uow.ProprietarioRepository.ObterPorId(request.Id);

            return _mapper.Map<ProprietarioViewModel>(resultDb);

        }
    }
}
