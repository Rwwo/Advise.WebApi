using System.Net;

using advise.webapi.application.CQCorretorInquiloContatos;
using advise.webapi.core.InputModels;
using advise.webapi.core.Interfaces;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace advise.webapi.api.Controllers
{
    [Route("api/corretorinquilinocontatos")]
    //[Authorize]
    public class CorretorInquilinoContatosController : MainController
    {
        private readonly IMediator _mediator;
        public CorretorInquilinoContatosController(IMediator mediator,
            INotificador notificador) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CorretorInquilinoContatosViewModel>> Adicionar(CorretorInquilinoContatosViewModel CorretorInquilinoContatosViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var criarCorretorInquilinoContatosCommand = new CriarCorretorInquiloContatosCommand(CorretorInquilinoContatosViewModel);
            var result = await _mediator.Send(criarCorretorInquilinoContatosCommand);

            return CustomResponse(HttpStatusCode.Created, CorretorInquilinoContatosViewModel);
        }

    }
}
