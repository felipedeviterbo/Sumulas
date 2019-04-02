/* -> Campos [ Data, Horario, descricao, campeonato, fase campeonato, num gols equipe, num gols visitante, resultado(Vitoria, Empate, Derrota), Arbitros, EquipeVisitante, Equipe ]
	--> Arbitros: Nome, Função
	--> Equipe Visitante [Nome, Gols, Cartoes Amarelo, Cartoes Vermelho, Jogadores]
	--> Equipe Principal [Nome, Gols, Cartoes Amarelo, Cartoes Vermelho, Jogadores]
		---> Jogadores: Nome, Numero, Documento */

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class Partida: Entity
    {
        public Partida(){
            Arbitros = new List<Arbitro>();
        }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Descricao { get; set; }
        public FasesCampeonato Fase { get; set; }
        public int GolsEquipeCasa { get; set; }
        public int GolsEquipeFora { get; set; }
        //public Resultado Resultado { get; set; }
        public IEnumerable<Arbitro> Arbitros { get; set; }
        public Equipe EquipeVisitante { get; set; }
        public Equipe Equipe { get; set; }

    }

    
}
