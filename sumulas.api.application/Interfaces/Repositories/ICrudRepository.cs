using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sumulas.api.application.Interfaces.Repositories
{
    public interface ICrudRepository<T>
    {
        Task<T> Insert(T item);
        Task<bool> Update(T item);
        Task<T> GetById(string Id);
    }
}
