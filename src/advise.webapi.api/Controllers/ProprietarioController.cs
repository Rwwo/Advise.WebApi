using advise.webapi.api.InputModels;
using advise.webapi.application.CQProprietario;
using advise.webapi.core.Interfaces;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace advise.webapi.api.Controllers
{
    [Route("api/proprietario")]
    //[Authorize]
    public class ProprietarioController : MainController
    {
        private readonly IMediator _mediator;
        public ProprietarioController(IMediator mediator,
            INotificador notificador) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<ProprietarioViewModel>>> ObterTodos()
        {
            var obterTodosProprietariosQuery = new ObterTodosProprietarioQuery();
            var result = await _mediator.Send(obterTodosProprietariosQuery);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ProprietarioViewModel>> ObterPorId(Guid id)
        {
            var obterPorIdQuery = new ObterPorIdProprietarioQuery(id);
            var Proprietario = await _mediator.Send(obterPorIdQuery);

            if (Proprietario == null)
                return NotFound();

            return Proprietario;
        }

        [HttpPost]
        public async Task<ActionResult<ProprietarioViewModel>> Adicionar(ProprietarioViewModel ProprietarioViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var criarProprietarioCommand = new CriarProprietarioCommand(ProprietarioViewModel);
            var result = await _mediator.Send(criarProprietarioCommand);

            return CustomResponse(HttpStatusCode.Created, ProprietarioViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ProprietarioViewModel>> Atualizar(Guid id, ProprietarioViewModel ProprietarioViewModel)
        {
            if (id != ProprietarioViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse();
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var atualizarProprietarioCommand = new AtualizarProprietarioCommand(ProprietarioViewModel);
            var result = await _mediator.Send(atualizarProprietarioCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }


        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProprietarioViewModel>> Excluir(Guid id)
        {
            var deletarProprietarioCommand = new DeletarProprietarioCommand(id);
            var result = await _mediator.Send(deletarProprietarioCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }

    }
}
