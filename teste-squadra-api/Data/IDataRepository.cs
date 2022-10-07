using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_squadra_api.Data
{
    public interface IDataRepository
    {
        List<Evento> GetEventoss();
        Evento AddEento(Evento evento);
    }
}
