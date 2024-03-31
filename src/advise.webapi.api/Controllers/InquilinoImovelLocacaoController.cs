using advise.webapi.api.InputModels;
using advise.webapi.application.CQCorretorProprietarioContatos;
using advise.webapi.application.CQImovel;
using advise.webapi.application.CQInquilinoImovelLocacao;
using advise.webapi.core.Interfaces;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using System.Net;

namespace advise.webapi.api.Controllers
{
    [Route("api/inquilinoimovellocacao")]
    //[Authorize]
    public class InquilinoImovelLocacaoController : MainController
    {
        private readonly IMediator _mediator;
        public InquilinoImovelLocacaoController(IMediator mediator,
            INotificador notificador) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<InquilinoImovelLocacaoDetalhadaViewModel>>> ObterTodosComDadosAdicionais()
        {
            var obterTodosImovelsQuery = new ObterTodosInquilinoImovelLocacaoQuery();
            var result = await _mediator.Send(obterTodosImovelsQuery);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<InquilinoImovelLocacaoViewModel>> Adicionar(InquilinoImovelLocacaoViewModel inquilinoImovelLocacaoViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var criarInquilinoImovelLocacaoCommand = new CriarInquilinoImovelLocacaoCommand(inquilinoImovelLocacaoViewModel);
            var result = await _mediator.Send(criarInquilinoImovelLocacaoCommand);

            return CustomResponse(HttpStatusCode.Created, inquilinoImovelLocacaoViewModel);
        }

        [HttpPut]
        public async Task<ActionResult<InquilinoImovelLocacaoViewModel>> Atualizar(InquilinoImovelLocacaoViewModel inquilinoImovelLocacaoViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var atualizarInquilinoImovelLocacaoCommand = new AtualizarInquilinoImovelLocacaoCommand(inquilinoImovelLocacaoViewModel);
            var result = await _mediator.Send(atualizarInquilinoImovelLocacaoCommand);

            return CustomResponse(HttpStatusCode.Created, inquilinoImovelLocacaoViewModel);
        }
    }
}
