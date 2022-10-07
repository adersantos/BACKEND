using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_squadra_api.Queries
{
    public record GetEventoListQuery() : IRequest<List<Evento>>;
}
