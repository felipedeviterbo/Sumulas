using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class Jogador: Entity
    {// Nome, Numero, Documento
        public string Name { get; set; }
        public string Apelido { get; set; }
        public int Numero { get; set; }
        public string Documento { get; set; }
    }

    
}
