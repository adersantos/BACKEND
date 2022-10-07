using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_squadra_api.Handlers
{
    public class AddEventoHandler : IRequestHandler<AddEventoCommand, Evento>
    {
        private readonly IDataRepository _dataRepository;

        public AddEventoHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }   

        public Task<Evento> Handle(AddEventoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddEvento(request.model));
        }
    }
}
