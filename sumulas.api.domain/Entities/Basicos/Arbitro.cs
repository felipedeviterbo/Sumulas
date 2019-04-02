using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class Arbitro
    {
        // public Campeonatos(){
        //     Fases = new List<FasesCampeonato>();
        // }
        public string Name { get; set; }
        public FuncaoArbitro Function { get; set; }

    }

    
}
