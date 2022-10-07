using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace teste_squadra_api.Handlers
{
    public class GetEventoListHandler : IRequestHandler<GetEventoListQuery, List<EventoModel>>
    {
        private readonly IDataRepository _dataRepository;

        public GetEventoListHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public Task<List<EventoModel>> Handle(GetEventoListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetEventos());
        }
    }
}
