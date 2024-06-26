﻿using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;
using advise.webapi.core.Models;
using advise.webapi.core.Models.Validations;
using advise.webapi.core.Services;

using AutoMapper;

using MediatR;

namespace advise.webapi.application.CQInquilinoImovelLocacao
{
    public class AtualizarInquilinoImovelLocacaoCommandHandler : BaseService, IRequestHandler<AtualizarInquilinoImovelLocacaoCommand, InquilinoImovelLocacaoViewModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public AtualizarInquilinoImovelLocacaoCommandHandler(IUnitOfWork uow, IMapper mapper, INotificador notificador)
            : base(notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<InquilinoImovelLocacaoViewModel> Handle(AtualizarInquilinoImovelLocacaoCommand request, CancellationToken cancellationToken)
        {
            var InquilinoImovelLocacaoMap = _mapper.Map<InquilinoImovelLocacao>(request.InquilinoImovelLocacao);

            if (!ExecutarValidacao(new InquilinoImovelLocacaoValidation(), InquilinoImovelLocacaoMap))
                return request.InquilinoImovelLocacao;


            await _uow.InquilinoImovelLocacaoRepository.Atualizar(InquilinoImovelLocacaoMap);

            return request.InquilinoImovelLocacao;

        }
    }
}
