using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_squadra_api.Data
{
    public class DataRepository : IDataRepository
    {

        private static List<Evento> _Eventos = new()
        {
            new Evento { Id = 1, Name = "Test Evento 1", Cost = 200m },
            new Evento { Id = 2, Name = "Test Evento 2", Cost = 300m }

        };

       
        public Evento AddEvento(Evento Evento)
        {
           
            _Eventos.Add(Evento);
            return Evento;
        }

        public List<Evento> GetEventos()
        {
            return _Eventos;
        }
    }
}
