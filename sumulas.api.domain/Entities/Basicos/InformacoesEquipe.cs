using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class InformacoesEquipe
    {
        public InformacoesEquipe() {
            Titulos = new List<Titulo>();
        }
        public string Name { get; set; }
        public int AnoFundacao { get; set; }
        public string Escudo { get; set; }
        public IEnumerable<Titulo> Titulos { get; set; }

    }

    
}
