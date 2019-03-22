using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.application.Interfaces.Repositories
{
    public interface ICrudRepository<T>
    {
        T Insert(T item);
        bool Update(T item);
        T GetById(string Id);
    }
}
