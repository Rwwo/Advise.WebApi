using System.Net;

using advise.webapi.application.CQCorretor;
using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace advise.webapi.api.Controllers
{
    [Route("api/corretor")]
    //[Authorize]
    public class CorretorController : MainController
    {
        private readonly IMediator _mediator;
        public CorretorController(IMediator mediator,
            INotificador notificador) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<CorretorViewModel>>> ObterTodos()
        {
            var obterTodosCorretorsQuery = new ObterTodosCorretorQuery();
            var result = await _mediator.Send(obterTodosCorretorsQuery);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CorretorViewModel>> ObterPorId(Guid id)
        {
            var obterPorIdQuery = new ObterPorIdCorretorQuery(id);
            var Corretor = await _mediator.Send(obterPorIdQuery);

            if (Corretor == null)
                return NotFound();

            return Corretor;
        }

        [HttpPost]
        public async Task<ActionResult<CorretorViewModel>> Adicionar(CorretorViewModel CorretorViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var criarCorretorCommand = new CriarCorretorCommand(CorretorViewModel);
            var result = await _mediator.Send(criarCorretorCommand);

            return CustomResponse(HttpStatusCode.Created, CorretorViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<CorretorViewModel>> Atualizar(Guid id, CorretorViewModel CorretorViewModel)
        {
            if (id != CorretorViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse();
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var atualizarCorretorCommand = new AtualizarCorretorCommand(CorretorViewModel);
            var result = await _mediator.Send(atualizarCorretorCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }


        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<CorretorViewModel>> Excluir(Guid id)
        {
            var deletarCorretorCommand = new DeletarCorretorCommand(id);
            var result = await _mediator.Send(deletarCorretorCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }

    }
}
