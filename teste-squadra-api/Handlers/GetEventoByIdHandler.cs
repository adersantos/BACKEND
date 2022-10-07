using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_squadra_api.Handlers
{
    public class GetEventoByIdHandler : IRequestHandler<GetEventoByIdQuery, EventoModel>
    {
        private readonly IMediator _mediator;

        public GetEventoByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<EventoModel> Handle(GetEventoByIdQuery request, CancellationToken cancellationToken)
        {
            var Eventos = await _mediator.Send(new GetEventoListQuery());
            var Evento = Eventos.FirstOrDefault(u => u.Id == request.id);
            return Evento;
        }
    }
}
