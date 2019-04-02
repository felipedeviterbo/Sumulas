using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sumulas.api.application.Interfaces.Repositories
{
    public interface ISumulaApiRepository<T>
    {
        Task<IEnumerable<T>> Get();
    }
}
