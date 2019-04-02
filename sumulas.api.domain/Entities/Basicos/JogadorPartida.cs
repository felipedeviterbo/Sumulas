using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class JogadorPartida: Entity
    {// Nome, Numero, Documento
        public Jogador Jogador { get; set; }
        public int Gols { get; set; }
        public int CartoesAmarelo { get; set; }
        public int CartoesVermelho { get; set; }

    }

    
}
