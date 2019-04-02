using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class Uniformes: Entity
    {
        
        public string Name { get; set; }
        public int Year { get; set; }
        public string PhotoPath { get; set; }
    }

    
}
