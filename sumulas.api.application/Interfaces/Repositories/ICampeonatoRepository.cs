using sumulas.api.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sumulas.api.application.Interfaces.Repositories
{
    public interface ICampeonatoRepository : ICrudRepository<Campeonatos>, ISumulaApiRepository<Campeonatos>
    {
        IEnumerable<Campeonatos> ListByYear(int Year);
        IEnumerable<Campeonatos> ListByPeriod(int YearIni, int YearEnd);

        Task<Campeonatos> GetByModel(string Nome, int year);


    }
}
