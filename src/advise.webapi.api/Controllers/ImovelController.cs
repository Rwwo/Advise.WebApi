using System.Net;

using advise.webapi.application.CQImovel;
using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace advise.webapi.api.Controllers
{
    [Route("api/imovel")]
    //[Authorize]
    public class ImovelController : MainController
    {
        private readonly IMediator _mediator;
        public ImovelController(IMediator mediator,
            INotificador notificador) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<ImovelViewModel>>> ObterTodos()
        {
            var obterTodosImovelsQuery = new ObterTodosImovelQuery();
            var result = await _mediator.Send(obterTodosImovelsQuery);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ImovelViewModel>> ObterPorId(Guid id)
        {
            var obterPorIdQuery = new ObterPorIdImovelQuery(id);
            var Imovel = await _mediator.Send(obterPorIdQuery);

            if (Imovel == null)
                return NotFound();

            return Imovel;
        }

        [HttpPost]
        public async Task<ActionResult<ImovelViewModel>> Adicionar(ImovelViewModel ImovelViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var criarImovelCommand = new CriarImovelCommand(ImovelViewModel);
            var result = await _mediator.Send(criarImovelCommand);

            return CustomResponse(HttpStatusCode.Created, ImovelViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ImovelViewModel>> Atualizar(Guid id, ImovelViewModel ImovelViewModel)
        {
            if (id != ImovelViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse();
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var atualizarImovelCommand = new AtualizarImovelCommand(ImovelViewModel);
            var result = await _mediator.Send(atualizarImovelCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }


        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ImovelViewModel>> Excluir(Guid id)
        {
            var deletarImovelCommand = new DeletarImovelCommand(id);
            var result = await _mediator.Send(deletarImovelCommand);

            return CustomResponse(HttpStatusCode.NoContent);
        }

    }
}
