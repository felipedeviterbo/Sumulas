using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.domain.Validations
{
    public interface IValidation<T>
    {
        ValidationResult IsValid(T entity);
    }
}
