using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.domain
{
    [Serializable]
    public class ValidationResult
    {
        public ValidationResult(ValidationResult result)
        {
            if (result == null)
                return;
        }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsFailure { get; set; }

    }

   
}
