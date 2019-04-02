using sumulas.api.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sumulas.api.application.Interfaces
{
    public interface ICampeonatosService
    {
        IEnumerable<CampeonatoModel> Get();
        Task<CampeonatoModel> Insert(CampeonatoModel campeonato);
        Task<CampeonatoModel> Update(CampeonatoModel campeonato);
        Task<bool> Delete(CampeonatoModel campeonato);
    }
}
