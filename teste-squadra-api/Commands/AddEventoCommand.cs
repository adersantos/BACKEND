using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_squadra_api.Commands
{
    public record AddEventoCommand(Evento model) : IRequest<Evento>;
    
}
