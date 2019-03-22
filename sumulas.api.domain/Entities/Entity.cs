using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.domain.Entities
{
    public class Entity
    {
        private string _id;
        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                    _id = Guid.NewGuid().ToString();
                return _id;
            }
            set => _id = value;
        }
    }
}
