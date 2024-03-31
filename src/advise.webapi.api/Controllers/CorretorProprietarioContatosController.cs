using System.Net;

using advise.webapi.application.CQCorretorProprietarioContatos;
using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace advise.webapi.api.Controllers
{
    [Route("api/corretorproprietariocontatos")]
    //[Authorize]
    public class CorretorProprietarioContatosController : MainController
    {
        private readonly IMediator _mediator;
        public CorretorProprietarioContatosController(IMediator mediator,
            INotificador notificador) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CorretorProprietarioContatosViewModel>> Adicionar(CorretorProprietarioContatosViewModel CorretorProprietarioContatosViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var criarCorretorProprietarioContatosCommand = new CriarCorretorProprietarioContatosCommand(CorretorProprietarioContatosViewModel);
            var result = await _mediator.Send(criarCorretorProprietarioContatosCommand);

            return CustomResponse(HttpStatusCode.Created, CorretorProprietarioContatosViewModel);
        }

    }
}
