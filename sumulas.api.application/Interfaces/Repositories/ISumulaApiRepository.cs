using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.application.Interfaces.Repositories
{
    public interface ISumulaApiRepository<T>
    {
        IEnumerable<T> Get();
    }
}
