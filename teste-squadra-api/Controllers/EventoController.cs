using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace teste_squadra_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Evento>> Get()
        {
            return await _mediator.Send(new GetEventoListQuery());
        }

        [HttpGet("{id}")]
        public async Task<Evento> Get(int id)
        {
            return await _mediator.Send(new GetEventoByIdQuery(id));
        }

        [HttpPost]
        public async Task<Evento> Post(Evento EventoModel)
        {
            return await _mediator.Send(new AddEventoCommand(EventoModel));
        }
        
    }
}
