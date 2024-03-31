using System.Net;

using advise.webapi.application.CQInquilino;
using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace advise.webapi.api.Controllers
{
    [Route("api/inquilino")]
    //[Authorize]
    public class InquilinoController : MainController
    {
        private readonly IMediator _mediator;
        public InquilinoController(IMediator mediator,
            INotificador notificador) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<InquilinoViewModel>>> ObterTodos()
        {
            var obterTodosInquilinosQuery = new ObterTodosInquilinosQuery();
            var result = await _mediator.Send(obterTodosInquilinosQuery);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<InquilinoViewModel>> ObterPorId(Guid id)
        {
            var obterPorIdQuery = new ObterPorIdInquilinosQuery(id);
            var inquilino = await _mediator.Send(obterPorIdQuery);

            if (inquilino == null)
                return NotFound();

            return inquilino;
        }

        [HttpPost]
        public async Task<ActionResult<InquilinoViewModel>> Adicionar(InquilinoViewModel inquilinoViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var criarInquilinoCommand = new CriarInquilinosCommand(inquilinoViewModel);
            var result = await _mediator.Send(criarInquilinoCommand);

            return CustomResponse(HttpStatusCode.Created, inquilinoViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<InquilinoViewModel>> Atualizar(Guid id, InquilinoViewModel InquilinoViewModel)
        {
            if (id != InquilinoViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse();
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var atualizarInquilinoCommand = new AtualizarInquilinosCommand(InquilinoViewModel);
            var result = await _mediator.Send(atualizarInquilinoCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }


        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<InquilinoViewModel>> Excluir(Guid id)
        {
            var deletarInquilinoCommand = new DeletarInquilinosCommand(id);
            var result = await _mediator.Send(deletarInquilinoCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }

    }
}
