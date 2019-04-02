using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class Equipe
    {//Equipe Visitante [Nome, Gols, Cartoes Amarelo, Cartoes Vermelho, Jogadores]
        public Equipe(){
            Jogadores = new List<JogadorPartida>();
        }
        public string Name { get; set; }
        public int Gols { get; set; }
        public int CartoesAmarelo { get; set; }
        public int CartoesVermelho { get; set; }
        public IEnumerable<JogadorPartida> Jogadores { get; set; }

    }

    
}
