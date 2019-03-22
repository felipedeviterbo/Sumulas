using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.domain.Exceptions
{
    public class BusinessRuleViolatedException: Exception
    {
        public BusinessRuleViolatedException(string message)
            : base(message)
        { 
        }
    }
}
