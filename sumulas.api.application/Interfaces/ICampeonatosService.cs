using sumulas.api.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.application.Interfaces
{
    public interface ICampeonatosService
    {
        IEnumerable<CampeonatoModel> Get();
        CampeonatoModel Insert(CampeonatoModel campeonato);
        CampeonatoModel Update(CampeonatoModel campeonato);
        bool Delete(CampeonatoModel campeonato);
    }
}
