using sumulas.api.domain.Entities.Basicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.application.Interfaces.Repositories
{
    public interface ICampeonatoRepository : ICrudRepository<Campeonatos>, ISumulaApiRepository<Campeonatos>
    {
        IEnumerable<Campeonatos> ListByYear(int Year);
        IEnumerable<Campeonatos> ListByPeriod(int YearIni, int YearEnd);
       
    }
}
